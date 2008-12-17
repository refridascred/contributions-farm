using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up graph layout samples.</summary>
        public static long PairGraphLayoutCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Closed,
            Locked,
            Active,
            Synced,
            Ready,
        }
    }
}
