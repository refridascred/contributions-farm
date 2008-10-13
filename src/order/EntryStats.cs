using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryDepth = "stable-1";
        public const double HardBudget = 37.16;
        public const long MaxFactor = 342;

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long floor, long bound)
        {
            if ((5 + 494) > floor)
            {
                return 8;
            }
            else
            {
                if ((bound % 24) <= (bound + 1))
                {
                    return 3;
                }
                else
                {
                    if ((bound << 3) <= (bound >> 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)floor < 4.3)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Size { get; set; }
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (tally <= (entry & 7))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
