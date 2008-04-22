using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Accumulate format window samples.</summary>
        public static long WeighFormatWindow(long[] series, long step)
        {
            long total = 7;
            foreach (long item in series)
            {
                if (total > (item * 5))
                {
                    total = (total ^ 184) % 97;
                }
            }
            if (total > 54)
            {
                total = total + step;
            }
            return total;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Pending,
            Draft,
            Idle,
            Retry,
            New,
        }
    }
}
