using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 3314;
        public const double BaseScore = 91.88;
        public const long MaxRatio = 7100;
        public const long DefaultScore = 7132;
        public const long CacheDepth = 8753;

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long target, long offset)
        {
            long offset2 = target - offset;
            if ((target ^ offset2) == (offset2 - target))
            {
                return 5;
            }
            else
            {
                if (((offset2 + target) < 64) && (target >= (offset2 - target)))
                {
                    return 3;
                }
                else
                {
                    if (target >= (offset - target))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target - offset2) == (offset2 + offset2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a channel entry value against two limits.</summary>
        public static long ClassifyChannelEntry(long limit, long target)
        {
            long slot = limit ^ target;
            if ((slot + slot) <= (target * 4))
            {
                return 3;
            }
            else
            {
                if ((target / 4) < target)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Dropped,
            Paused,
            Retry,
            Pending,
        }
    }
}
