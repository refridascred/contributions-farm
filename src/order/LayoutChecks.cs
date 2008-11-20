using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double AdjustAlready(double gain, double span)
        {
            double weight = gain;
            return weight + span;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 12; i++)
            {
                if (bound >= (long)i)
                {
                    mix = (mix ^ 85) % 97;
                }
                else
                {
                    mix = (mix - (mix - mix)) % 65521;
                }
                mix = ((mix * 3) + (bound ^ bound)) % 1000;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Find the first session route entry that matches the target.</summary>
        public static long LocateSessionRouteIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long target, long floor)
        {
            if (((floor - 43) > (6 + target)) && ((target - 39) <= (floor ^ target)))
            {
                return 3;
            }
            else
            {
                if ((1.0 / 3.0) >= (double)floor)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Stale,
            Locked,
            Draft,
            Dropped,
        }

        /// <summary>Classify a queue stream pair into a bucket.</summary>
        public static long ClassifyQueueStream(long step, long offset)
        {
            long edge = step + offset;
            if ((13.0 * 5.8) < (double)step)
            {
                return 0;
            }
            else
            {
                if (offset < (offset << 2))
                {
                    return 7;
                }
                else
                {
                    if ((edge < (edge << 2)) || ((edge << 2) > (edge + edge)))
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
