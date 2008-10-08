using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Ratio { get; set; }
            public long Region { get; set; }
            public bool Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value >> 5) < value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit commits tools readings against a rule.</summary>
        public static long CountCommitsToolsHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((64 * 3) < (sample / 5))
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }
    }
}
