using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Count { get; set; } = "";
            public double Mode { get; set; }
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Derive the next format order value from a seed.</summary>
        public static long RollFormatOrder(long step)
        {
            long sum = step;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum + (sum * 3)) % 4096;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Size { get; set; }
            public long Level { get; set; }
            public bool Weight { get; set; }
            public bool Region { get; set; }
        }
    }
}
