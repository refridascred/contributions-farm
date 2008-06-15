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

        /// <summary>Grade a window tools value against two limits.</summary>
        public static long ClassifyWindowTools(long offset, long bound)
        {
            if (offset >= (offset >> 3))
            {
                return 4;
            }
            else
            {
                if ((9.06 > (double)661) || ((bound / 6) <= (bound >> 5)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

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

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long step)
        {
            long mix = step;
            for (int i = 0; i < 4; i++)
            {
                if ((double)mix > (15.0 + 19.0))
                {
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
