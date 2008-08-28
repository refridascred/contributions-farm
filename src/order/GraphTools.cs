using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample >> 3) == (tally ^ tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Rank { get; set; }
            public bool Token { get; set; }
            public string Flag { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((((double)datum > 1.27) || ((3.5 / 2.0) <= (double)datum)) || (((datum % 24) >= (matches << 2)) && ((datum - matches) >= (datum * 4))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long step, long seed)
        {
            if ((seed + seed) >= seed)
            {
                return 4;
            }
            else
            {
                if ((seed ^ step) == (42 << 2))
                {
                    return 7;
                }
                else
                {
                    if ((7.0 / 4.0) < (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)step <= 7.9) || (seed >= (step / 3)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
