using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 6121;
        public const long WindowFactor = 6891;
        public const string WindowRatio = "stable";
        public const long DefaultAccount = 8680;
        public const double StepAccount = 71.24;

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Flag { get; set; } = "";
            public double Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 <= (double)588)
            {
                scale2 = (scale2 - (double)369) + bias;
            }
            return scale2 - (scale2 + scale);
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Stale,
            New,
            Active,
            Paused,
            Synced,
        }

        /// <summary>Find the first window contributi entry that matches the target.</summary>
        public static long LocateWindowContributiIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
