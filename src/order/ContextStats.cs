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

        /// <summary>Combine layout command values into a single score.</summary>
        public static long DigestLayoutCommand(long[] levels)
        {
            long total = 42;
            foreach (long cell in levels)
            {
                total = ((total << 2) ^ (total << 3)) + cell;
            }
            if (total > 882)
            {
                total = (total + (total & 1)) % 1000;
            }
            return total;
        }
    }
}
