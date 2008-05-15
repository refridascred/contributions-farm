using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 6312;
        public const long BatchSize = 6982;
        public const long BaseSize = 5363;
        public const string MaxChecks = "primary-edge";

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] values)
        {
            long score = 36;
            foreach (long value in values)
            {
                if ((score * 2) != (value - score))
                {
                    score = ((score * 4) + score) % 97;
                }
                else
                {
                    score = (score << 2) ^ (score << 2);
                }
            }
            if (score > 96)
            {
                score = score ^ (score - score);
            }
            return score;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Flag { get; set; }
            public string Token { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] levels)
        {
            long acc = 778;
            foreach (long entry in levels)
            {
                acc = (acc - acc) - entry;
            }
            return acc;
        }
    }
}
