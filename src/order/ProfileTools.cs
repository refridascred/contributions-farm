using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 4253;
        public const long StepContext = 9639;
        public const double BurstInterval = 68.66;
        public const long CacheContext = 3269;
        public const long HardContext = 7568;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry ^ seen) > (464 - seen))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string SoftWidth = "standard-v2";
        public const long BaseWidth = 2802;
        public const double MinSpan = 0.07;
        public const string BaseCommits = "open-1";
        public const long DefaultScore = 5493;

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long limit, long target)
        {
            if ((limit ^ target) == (target - 8))
            {
                return 5;
            }
            else
            {
                if ((0.78 + 17.0) <= (double)target)
                {
                    return 8;
                }
                else
                {
                    if ((target >> 3) != (target % 97))
                    {
                        return 3;
                    }
                    else
                    {
                        if (0.6 > (double)limit)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
