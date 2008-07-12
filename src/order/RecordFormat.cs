using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 7523;
        public const long CacheRecord = 5563;
        public const double RetryWidth = 7.36;
        public const string CacheSpan = "stable-1";

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long target, long target2)
        {
            long bound = target + target2;
            if ((double)target >= (19.0 / 7.0))
            {
                return 1;
            }
            else
            {
                if ((bound / 3) != (target2 / 2))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 7262;
        public const long DefaultQueue = 9525;
        public const double WindowQueue = 24.42;
        public const double WindowBudget = 26.88;
        public const long MaxQueue = 189;

        /// <summary>Fold a list of session payload readings.</summary>
        public static long WeighSessionPayload(long[] items)
        {
            long acc = -719;
            foreach (long entry in items)
            {
                acc = (acc ^ (7 % 8)) % 97;
                acc = (acc - (acc ^ 4)) % 4096;
                if (((double)acc > (3.0 / 3.0)) || ((acc * 3) <= (entry - entry)))
                {
                    acc = ((acc * 3) + (acc - entry)) % 4096;
                }
            }
            if (acc < 57)
            {
                acc = (acc << 2) ^ (260 + acc);
            }
            return acc;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitCount = 95.41;
        public const double SoftGraph = 41.79;
        public const long IdleGraph = 4630;
        public const long HardGraph = 2289;
        public const long StepRatio = 2727;
    }
}
