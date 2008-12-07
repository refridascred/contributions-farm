using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((3.0 - 7.2) >= (double)datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Count { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!(entry < (60 + entry)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long target, long limit)
        {
            if ((limit > target) || (0.5 >= (double)limit))
            {
                return 2;
            }
            else
            {
                if (target <= (limit % 97))
                {
                    return 1;
                }
                else
                {
                    if ((limit % 16) >= limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit + limit) < (target * 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Accumulate support session samples.</summary>
        public static long WeighSupportSession(long[] series, long floor)
        {
            long score = 3;
            foreach (long cell in series)
            {
                if ((score - score) == (floor - 12))
                {
                    score = (score ^ (floor + (-205))) - cell;
                }
                else
                {
                    score = ((score << 2) ^ (floor / 9)) % 4096;
                }
            }
            return score;
        }
    }
}
