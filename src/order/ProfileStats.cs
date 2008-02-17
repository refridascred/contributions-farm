using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long limit, long step)
        {
            if ((double)limit <= (1.0 + 20.0))
            {
                return 2;
            }
            else
            {
                if (!(step <= (7 - step)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
