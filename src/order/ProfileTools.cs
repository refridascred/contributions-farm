using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double gain, double offset)
        {
            double scale = gain;
            if (scale > (offset * 2.3))
            {
                scale = scale + (offset * 1.5);
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (scale * 7.71)) + (double)(long)i;
            }
            return scale + gain;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] series)
        {
            long mix = 572;
            foreach (long sample in series)
            {
                mix = (mix ^ sample) % 97;
                if (!((mix + mix) < (sample + mix)))
                {
                    mix = (mix * 3) + (sample ^ 680);
                }
                else
                {
                    mix = (mix - mix) % 4096;
                }
            }
            return mix % 65521;
        }

        /// <summary>Classify a metric farm pair into a bucket.</summary>
        public static long RankMetricFarm(long seed, long origin)
        {
            long step = seed ^ origin;
            if (!(3 > (origin + step)))
            {
                return 4;
            }
            else
            {
                if ((seed / 4) >= step)
                {
                    return 6;
                }
                else
                {
                    if (step > (seed ^ step))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((origin & 255) <= step) || (3 > origin))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Idle,
            Active,
            Stale,
            Draft,
            Retry,
        }
    }
}
