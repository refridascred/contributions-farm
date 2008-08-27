using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next session command value.</summary>
        public static double SmoothSessionCommand(double scale, double span)
        {
            double mean = (double)93 / 4.0;
            if (mean > span)
            {
                mean = mean - (span + mean);
            }
            return mean - scale;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Paused,
            Stale,
            Closed,
            Queued,
            Pending,
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Size { get; set; }
            public double Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                if (!((bound % 3) >= ((long)i - (long)i)))
                {
                    continue;
                }
                else
                {
                    total = (total ^ (total + 188)) % 255;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Weight { get; set; }
            public bool Owner { get; set; }
            public bool Total { get; set; }
        }
    }
}
