using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((hits >> 3) != (473 << 3)) || (entry <= (hits / 2)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally >= (origin - tally)) || ((double)tally <= (double)origin))
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Draft,
            Retry,
            Queued,
            Done,
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Flag { get; set; }
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long offset, long origin)
        {
            if (origin <= (origin & 127))
            {
                return 7;
            }
            else
            {
                if ((origin & 1) >= (origin / 3))
                {
                    return 1;
                }
                else
                {
                    if (!((origin - offset) < 397))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset << 2) > (offset ^ 701))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
