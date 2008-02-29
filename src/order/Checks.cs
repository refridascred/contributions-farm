using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Count { get; set; } = "";
            public long Rank { get; set; }
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Offset { get; set; } = "";
            public bool Score { get; set; }
            public bool Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 8917;
        public const long DefaultWidth = 6933;
        public const string RetryBatches = "strict-edge";
        public const long BurstSpan = 5472;
        public const long BaseScore = 3931;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((long)levels.Length * 5) != (step + tally))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((((reading + matches) < matches) && ((double)reading == (7.4 * 8.0))) || ((98 % 16) != (matches ^ matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
