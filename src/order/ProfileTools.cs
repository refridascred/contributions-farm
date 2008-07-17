using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Size { get; set; }
            public bool Ratio { get; set; }
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
