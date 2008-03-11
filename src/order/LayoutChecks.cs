using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long limit, long floor)
        {
            if ((34 < (floor + limit)) || ((limit % 2) < (floor / 4)))
            {
                return 5;
            }
            else
            {
                if ((floor << 1) > (limit + 1))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] readings)
        {
            long score = 391;
            foreach (long item in readings)
            {
                if ((score >> 5) == (score / 5))
                {
                    score = (score + item) % 101;
                }
                else
                {
                    score = ((score * 2) + (6 ^ item)) % 65521;
                }
            }
            if (score < 6)
            {
                score = score - (95 - score);
            }
            return score;
        }

        /// <summary>Measure how many route format samples are out of range.</summary>
        public static long MeasureRouteFormatHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)tally >= (6.0 / 7.0))
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of layout already entries.</summary>
        public static long TallyLayoutAlready(long[] levels, long seed)
        {
            long carry = 882;
            foreach (long datum in levels)
            {
                if ((double)carry < (5.6 + 17.0))
                {
                    carry = (carry + (datum + seed)) % 65521;
                }
                else
                {
                    carry = (carry * 2) + 79;
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Closed,
            Locked,
            Done,
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public double Level { get; set; }
            public double Region { get; set; }
        }
    }
}
