using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Rank order command input into a small class.</summary>
        public static long BucketOrderCommand(long floor, long target)
        {
            long slot = floor - target;
            if (!(476 > (target * 4)))
            {
                return 8;
            }
            else
            {
                if ((floor - slot) > (floor * 4))
                {
                    return 6;
                }
                else
                {
                    if ((1.1 - 6.0) == (double)slot)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Pending,
            Closed,
            Draft,
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double gain, double floor)
        {
            double bias = 5.0;
            if (bias > (6.0 + gain))
            {
                bias = bias + 7.94;
            }
            else
            {
                bias = bias + (double)(-6);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (floor * 1.68)) + (double)(long)i;
            }
            return bias - (bias + 7.1);
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Score { get; set; }
            public bool Total { get; set; }
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheWidth = 1345;
        public const long HardOrder = 6126;
        public const double MinOrder = 13.79;
        public const long LimitLevel = 8077;
        public const double SoftOrder = 94.15;
    }
}
