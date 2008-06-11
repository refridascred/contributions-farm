using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Region { get; set; } = "";
            public double Mode { get; set; }
            public bool Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Offset { get; set; }
            public double Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((2.0 / 9.0) >= (double)entry) && (((entry << 1) <= entry) || ((matches >> 2) > (matches - matches))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
