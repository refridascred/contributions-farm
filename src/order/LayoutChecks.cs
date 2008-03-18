using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 4212;
        public const long MinInterval = 3777;
        public const string BurstEntry = "primary-1";
        public const string MinEntry = "alpha-v2";

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long target, long floor)
        {
            if (7 >= target)
            {
                return 1;
            }
            else
            {
                if ((target << 2) >= (target << 1))
                {
                    return 2;
                }
                else
                {
                    if (((9.27 - 2.0) == (double)floor) && ((8.96 + 11.0) >= (double)target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor - target) < (floor & 63))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public bool Flag { get; set; }
            public string Stamp { get; set; } = "";
            public double Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Blend two already support measurements.</summary>
        public static double AdjustAlreadySupport(double weight, double span)
        {
            double gain = (5.5 * 1.0) + (span - weight);
            if (gain > (gain / 2.0))
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + 3.0) - (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            New,
            Paused,
            Ready,
            Synced,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((matches + value) <= value) || ((double)matches > 6.9))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
