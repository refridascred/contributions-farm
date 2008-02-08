using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long bound, long bound2)
        {
            long edge = bound ^ bound2;
            if ((edge % 12) < (bound2 + edge))
            {
                return 7;
            }
            else
            {
                if (((double)edge >= (1.4 + 7.6)) && (213 >= (bound2 % 64)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 8123;
        public const string BatchAlready = "open";
        public const long SoftAlready = 6250;
        public const double StepAlready = 11.63;

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long limit, long bound)
        {
            if ((bound << 3) < (bound - bound))
            {
                return 1;
            }
            else
            {
                if ((limit / 8) > (339 & 31))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell / 3) <= (hits * 3))
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }
    }
}
