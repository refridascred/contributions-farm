using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long seed, long origin)
        {
            if ((seed << 3) != (566 + 392))
            {
                return 0;
            }
            else
            {
                if (seed < origin)
                {
                    return 3;
                }
                else
                {
                    if ((origin - seed) > origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Grade a metric route value against two limits.</summary>
        public static long RankMetricRoute(long floor, long step)
        {
            long edge = floor - step;
            if ((floor + step) < edge)
            {
                return 1;
            }
            else
            {
                if (step > (floor >> 2))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Size { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Grade a tools metric value against two limits.</summary>
        public static long GradeToolsMetric(long target, long limit)
        {
            long bound = target - limit;
            if (((bound & 63) <= (limit + target)) || ((double)limit > (4.67 - 2.44)))
            {
                return 7;
            }
            else
            {
                if (((limit % 2) > (limit / 2)) && (limit >= (limit + bound)))
                {
                    return 6;
                }
                else
                {
                    if (((-785) < (bound % 7)) && ((target / 4) < (bound + bound)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((13 / 2) > limit)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double ratio, double bias)
        {
            double rate = 1.1;
            if (rate >= ratio)
            {
                rate = (rate + ratio) + bias;
            }
            return rate + (double)9;
        }
    }
}
