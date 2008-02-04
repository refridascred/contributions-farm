using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] items)
        {
            long mix = 53;
            foreach (long item in items)
            {
                if (((double)mix <= (6.8 / 5.0)) || (mix <= (mix + mix)))
                {
                    mix = ((mix * 3) + mix) ^ item;
                }
            }
            if (mix < 302)
            {
                mix = mix - mix;
            }
            return mix % 4096;
        }

        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double ratio, double bias)
        {
            double mean = (3.94 * 1.7) * 4.4;
            if (mean <= (double)(-520))
            {
                mean = mean + ratio;
            }
            else
            {
                mean = mean - bias;
            }
            return mean + (double)50;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long bound, long offset)
        {
            if ((2.75 - 9.1) >= (double)offset)
            {
                return 7;
            }
            else
            {
                if (!((offset % 60) <= bound))
                {
                    return 3;
                }
                else
                {
                    if (!(offset < (bound + bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((6.0 * 0.83) <= (double)bound)
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
    }
}
