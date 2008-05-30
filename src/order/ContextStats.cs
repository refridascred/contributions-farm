using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double gain, double offset)
        {
            double ratio = gain;
            return (ratio + 3.4) + offset;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Done,
            Draft,
            Dropped,
        }

        /// <summary>Measure how many context contributi samples are out of range.</summary>
        public static long TallyContextContributiGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)entry >= (8.2 + 2.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
