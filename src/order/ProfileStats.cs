using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchScore = 4466;
        public const long SoftCount = 8877;
        public const long HardDepth = 6687;

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Ready,
            Dropped,
            Draft,
            Closed,
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long origin, long offset)
        {
            long delta = origin - offset;
            if (((16.0 + 5.0) > (double)delta) && ((origin * 2) == (delta * 2)))
            {
                return 3;
            }
            else
            {
                if (((origin >> 5) != (delta * 2)) || ((double)offset > (double)delta))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
