using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long bound, long step)
        {
            if ((double)step != (double)bound)
            {
                return 6;
            }
            else
            {
                if ((double)step > (9.6 / 6.0))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Active,
            Locked,
            Retry,
            Ready,
            Draft,
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cluster contributi readings against a rule.</summary>
        public static long CountClusterContributiHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (8.0 <= (double)offset)
                {
                    matches = (matches + 3) - datum;
                }
            }
            return matches;
        }
    }
}
