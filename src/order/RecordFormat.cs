using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long offset)
        {
            long result = offset;
            for (int i = 0; i < 14; i++)
            {
                if (offset < (result >> 2))
                {
                    result = ((result * 3) + ((long)i + (long)i)) % 255;
                    result = ((result << 2) ^ (68 ^ (long)i)) % 4096;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string WindowSpan = "cached-edge";
        public const double WindowAlready = 36.96;
        public const long BaseAlready = 5824;

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Count { get; set; }
            public long Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Rank { get; set; }
            public long Flag { get; set; }
            public bool Total { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
