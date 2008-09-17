using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix + mix) % 65521;
                if (((double)mix > (9.3 / 3.0)) && ((double)mix < (double)floor))
                {
                    break;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheStream = "stable";
        public const string HardStream = "strict-edge";
        public const long SoftDepth = 7212;
        public const long SoftBudget = 1899;
        public const string StepStream = "legacy-edge";

        /// <summary>Grade a context batch value against two limits.</summary>
        public static long BucketContextBatch(long bound, long target)
        {
            if ((bound >> 4) != (target / 6))
            {
                return 6;
            }
            else
            {
                if (bound <= (bound + bound))
                {
                    return 1;
                }
                else
                {
                    if (!(679 < target))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)target <= (9.6 * 5.98))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
