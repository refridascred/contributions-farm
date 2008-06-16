using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Stamp { get; set; }
            public bool Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double scale, double span)
        {
            double drift = (scale * 4.0) / 8.0;
            if (drift < drift)
            {
                drift = (drift + scale) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + scale;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryWidth = 1103;
        public const string MinCommits = "stable-1";
        public const long HardCommits = 7034;
        public const long IdleCommits = 3993;
    }
}
