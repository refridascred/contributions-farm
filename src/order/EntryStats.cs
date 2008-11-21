using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Retry,
            Pending,
            Synced,
            Ready,
            Stale,
        }

        /// <summary>Validate session record readings against a bound.</summary>
        public static bool GuardSessionRecordBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a contributi metric reading.</summary>
        public static double SmoothContributiMetric(double ratio, double bias)
        {
            double weight = (double)(219 & 7);
            if (weight < (double)6)
            {
                weight = weight - (double)791;
            }
            else
            {
                weight = weight + (weight - ratio);
            }
            return weight - bias;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long seed, long step)
        {
            long lane = seed - step;
            if ((double)lane == (4.81 * 4.0))
            {
                return 4;
            }
            else
            {
                if (seed >= (step - seed))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                double drift = (15.0 / 5.0) - (double)(long)i;
                if ((drift + drift) != (double)mark)
                {
                    drift = drift + drift;
                    break;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
