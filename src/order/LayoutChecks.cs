using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 9358;
        public const string BatchSize = "fallback";
        public const long WindowCount = 4402;
        public const double IdleChannel = 47.47;

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

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] levels, long target)
        {
            long acc = -77;
            foreach (long sample in levels)
            {
                if ((960 >> 5) > (acc - target))
                {
                    acc = acc - (target & 3);
                }
                if (((double)sample != (7.5 - 10.0)) || ((sample ^ target) > 5))
                {
                    break;
                }
            }
            if (acc > 1)
            {
                acc = acc - (target + acc);
            }
            return acc;
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
