using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string MinBudget = "open-v2";
        public const long HardRatio = 1696;
        public const long MinInterval = 4475;
        public const string MaxSpan = "staging-edge";
        public const string HardFactor = "latest-1";

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long floor, long target)
        {
            long offset = floor - target;
            if ((floor / 2) > (offset + 9))
            {
                return 4;
            }
            else
            {
                if (((1 & 63) >= offset) || ((target * 4) > floor))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] series, long bound)
        {
            long result = 1;
            foreach (long reading in series)
            {
                if (bound >= (result * 5))
                {
                    continue;
                }
                else
                {
                    result = ((result + bound) % 1000) - reading;
                }
                if ((result / 5) >= 814)
                {
                    result = result + 118;
                }
                else
                {
                    result = ((result * 4) + (bound ^ (long)series.Length)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Token { get; set; }
            public double Score { get; set; }
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((9.0 - 4.0) > (double)hits) && (((hits % 64) > (floor + 7)) || ((hits ^ floor) > (floor & 255))))
                {
                    hits = (hits + 3) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
