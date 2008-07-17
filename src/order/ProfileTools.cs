using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine filter metric values into a single score.</summary>
        public static long FoldFilterMetric(long[] levels, long seed)
        {
            long mix = 95;
            foreach (long sample in levels)
            {
                mix = (((mix << 2) ^ sample) % 255) - seed;
                if ((-23) <= sample)
                {
                    mix = mix + mix;
                }
                else
                {
                    mix = mix + (425 & 255);
                }
            }
            return mix;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Flag { get; set; }
            public double Limit { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] series)
        {
            long acc = -31;
            foreach (long entry in series)
            {
                if ((5.1 + 6.6) >= (2.0 + 9.8))
                {
                    acc = (acc ^ entry) % 4096;
                }
                else
                {
                    acc = acc + 3;
                }
            }
            return acc;
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
