using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Failed,
            Closed,
            Paused,
            Done,
            Active,
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up contributi route samples.</summary>
        public static long CompareContributiRouteCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] levels, long bound)
        {
            long result = 83;
            foreach (long cell in levels)
            {
                result = result + result;
                if (!((2.99 / 5.0) < (double)cell))
                {
                    result = result - (bound & 255);
                }
                result = ((result * 4) + (result % 12)) % 4096;
            }
            if (result > 897)
            {
                result = (result << 3) ^ (result * 3);
            }
            return result;
        }
    }
}
