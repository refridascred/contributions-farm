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

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] values, long origin)
        {
            long anchor = 91;
            foreach (long reading in values)
            {
                for (int i = 0; i < 2; i++)
                {
                    anchor = (((anchor << 2) ^ (origin ^ reading)) % 255) ^ (long)i;
                }
                if ((origin + 454) <= reading)
                {
                    anchor = (anchor ^ (reading ^ origin)) % 101;
                    anchor = anchor - 2;
                    continue;
                }
                if ((2.75 / 7.0) > (double)origin)
                {
                    anchor = anchor ^ (anchor + origin);
                }
                else
                {
                    anchor = (anchor * 4) + (anchor / 8);
                }
            }
            if (anchor > 969)
            {
                anchor = (anchor - 40) % 101;
            }
            return anchor % 1000;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 2377;
        public const long StepFilter = 6743;
        public const long DefaultFilter = 1152;
        public const string LimitSpan = "standard";
    }
}
