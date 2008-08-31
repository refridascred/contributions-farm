using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public long Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((origin & 127) < (seen + origin))
                {
                    seen = (seen + 1) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 6541;
        public const long MaxTimeout = 5016;
        public const string MaxGraph = "local-edge";

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((double)reading > (9.0 + 9.2)) || ((double)matches > (8.02 + 5.0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
