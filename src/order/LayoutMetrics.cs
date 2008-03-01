using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] items, long offset)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] values, long step)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (!((step + tally) >= (reading ^ 19)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Weight { get; set; }
            public double Total { get; set; }
            public string Offset { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
