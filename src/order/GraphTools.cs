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

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long offset, long limit)
        {
            long cur = offset + limit;
            if (((limit & 31) > cur) || ((double)offset <= (10.0 * 8.66)))
            {
                return 7;
            }
            else
            {
                if ((cur >= (cur & 3)) || ((cur + 26) < cur))
                {
                    return 1;
                }
                else
                {
                    if ((limit - cur) > (7 >> 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((cur << 1) > (offset >> 5)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
