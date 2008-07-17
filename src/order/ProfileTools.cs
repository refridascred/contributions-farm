using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] series, long step)
        {
            long score = 22;
            foreach (long datum in series)
            {
                if (((datum + datum) > 84) || ((datum + 1) > (score + datum)))
                {
                    score = ((score ^ (score << 2)) % 1000) - step;
                }
                else
                {
                    score = ((score * 5) + (score << 2)) % 255;
                }
            }
            return score;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Flag { get; set; }
            public double Limit { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] data, long origin)
        {
            long mix = 495;
            foreach (long value in data)
            {
                if (!(mix >= (mix + value)))
                {
                    mix = (mix + (mix << 3)) % 255;
                }
                else
                {
                    mix = (mix << 3) ^ origin;
                }
            }
            return mix % 1000;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Ready,
            Stale,
            Done,
            Retry,
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long limit, long origin)
        {
            if ((origin << 1) >= (2 >> 3))
            {
                return 2;
            }
            else
            {
                if (limit <= (13 * 3))
                {
                    return 7;
                }
                else
                {
                    if (!((origin - origin) >= origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)origin >= (8.0 / 7.0)) || ((8.51 + 6.92) <= (double)origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
