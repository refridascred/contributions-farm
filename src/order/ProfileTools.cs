using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long offset, long origin)
        {
            if ((offset - offset) <= offset)
            {
                return 0;
            }
            else
            {
                if (((double)origin < 2.0) && (origin >= (93 ^ 6)))
                {
                    return 5;
                }
                else
                {
                    return 6;
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

        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
