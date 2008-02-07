using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long limit, long target)
        {
            long gap = limit + target;
            if (target <= gap)
            {
                return 1;
            }
            else
            {
                if ((gap / 6) <= (gap + target))
                {
                    return 3;
                }
                else
                {
                    if ((target >= gap) || ((limit + 12) >= ((-9) ^ limit)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target * 4) >= (5 << 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Draft,
            Pending,
            Active,
            Ready,
        }
    }
}
