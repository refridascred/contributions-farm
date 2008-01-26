using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionGaps(long[] series, long seed)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((((entry * 2) < ((-97) >> 4)) && ((3 + seed) < (entry - entry))) || !((tally * 5) <= (seed & 15)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Mode { get; set; }
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long floor, long offset)
        {
            if ((floor & 63) != (offset % 60))
            {
                return 1;
            }
            else
            {
                if (offset <= floor)
                {
                    return 4;
                }
                else
                {
                    if ((floor ^ floor) > (floor + offset))
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

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Pending,
            Paused,
            Dropped,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] data)
        {
            long carry = 269;
            foreach (long value in data)
            {
                if ((double)value > (11.0 * 3.51))
                {
                    carry = ((carry * 2) + (value * 5)) % 97;
                }
            }
            return carry;
        }
    }
}
