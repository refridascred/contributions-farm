using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public double Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public bool Total { get; set; }
        }
    }
}
