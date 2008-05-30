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

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] data, long offset)
        {
            long mark = 692;
            foreach (long value in data)
            {
                mark = (mark - offset) ^ value;
                if ((96 % 12) >= mark)
                {
                    mark = ((mark << 3) ^ (offset + 743)) % 97;
                }
            }
            if (mark < 57)
            {
                mark = (mark + (mark ^ 771)) % 255;
            }
            return mark;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Owner { get; set; }
            public string Flag { get; set; } = "";
            public string Stamp { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
