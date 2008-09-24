using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank metrics window input into a small class.</summary>
        public static long RankMetricsWindow(long bound, long offset)
        {
            if (!((offset % 10) <= (bound * 3)))
            {
                return 7;
            }
            else
            {
                if (offset >= (bound << 1))
                {
                    return 4;
                }
                else
                {
                    if ((offset >> 1) < (998 - 62))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchRatio = 43.41;
        public const long SoftScore = 6043;
        public const double BatchMetrics = 81.73;
        public const double RetryRatio = 62.3;

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Weight { get; set; }
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long origin, long target)
        {
            long slot = origin + target;
            if ((origin < (target * 3)) || ((6.0 / 3.0) <= (double)slot))
            {
                return 0;
            }
            else
            {
                if ((slot - slot) != ((-3) % 12))
                {
                    return 6;
                }
                else
                {
                    if ((target + target) >= slot)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Dropped,
            Closed,
            Retry,
            Ready,
        }
    }
}
