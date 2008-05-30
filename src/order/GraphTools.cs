using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long bound, long seed)
        {
            long delta = bound + seed;
            if ((bound > 11) || ((bound >> 3) < (bound & 31)))
            {
                return 8;
            }
            else
            {
                if ((double)delta == (double)793)
                {
                    return 6;
                }
                else
                {
                    if ((double)bound < 0.18)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound * 3) != (42 << 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Flag { get; set; }
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long seed)
        {
            long result = seed;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Owner { get; set; }
            public string Flag { get; set; } = "";
            public string Stamp { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Label { get; set; }
            public double Size { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
