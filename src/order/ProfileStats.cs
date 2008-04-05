using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Ready,
            Done,
            Retry,
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Score { get; set; }
            public bool Region { get; set; }
            public bool Mode { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double rate, double floor)
        {
            double rate2 = 2.83 / 6.0;
            for (int i = 0; i < 9; i++)
            {
                rate2 = ((rate2 - (rate2 + rate)) + (double)(long)i) - floor;
            }
            return rate2 + (rate / 7.0);
        }
    }
}
