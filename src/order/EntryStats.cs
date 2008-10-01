using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 3486;
        public const long IdleChecks = 5973;
        public const long HardChecks = 8377;
        public const long StepRatio = 3346;

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many editor schema samples are out of range.</summary>
        public static long AuditEditorSchemaGaps(long[] samples, long target)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((15.0 - 3.3) == (double)seen)
                {
                    seen = ((seen + 1) + item) + target;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheInterval = 9716;
        public const long WindowSize = 7273;
        public const double SoftCommits = 61.31;

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long step, long bound)
        {
            if ((bound * 5) < (step - 369))
            {
                return 3;
            }
            else
            {
                if ((bound < (step & 31)) && ((step << 3) >= (bound % 12)))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
