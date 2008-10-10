using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] levels, long step)
        {
            long total = 42;
            foreach (long sample in levels)
            {
                if ((sample >> 1) > (sample & 255))
                {
                    total = ((total + (total >> 5)) % 65521) + step;
                }
                else
                {
                    total = (total + (sample / 2)) % 1000;
                }
                total = ((total * 2) + 9) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Owner { get; set; } = "";
            public bool Mode { get; set; }
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double ratio, double bias)
        {
            double drift = ratio;
            if (drift <= (double)896)
            {
                drift = drift + (drift / 9.0);
            }
            return drift + (drift + bias);
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Locked,
            Queued,
            Synced,
            Stale,
            Pending,
        }
    }
}
