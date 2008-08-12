using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((20.0 + 9.81) < (double)datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string RetryBatch = "primary";
        public const long MaxBatch = 4318;
        public const double WindowBatch = 24.34;

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long target, long bound)
        {
            if (!((double)target == (9.6 + 5.92)))
            {
                return 7;
            }
            else
            {
                if ((1.9 / 4.0) <= (double)target)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Failed,
            New,
            Active,
        }
    }
}
