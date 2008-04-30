using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long origin)
        {
            long state = origin;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 5) + (7 << 3)) % 1000;
                state = (state + origin) % 65521;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionLimits(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Audit metric channel readings against a rule.</summary>
        public static long AuditMetricChannelHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!!((count / 8) <= (count * 3)))
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Combine cache entry values into a single score.</summary>
        public static long CombineCacheEntry(long[] readings, long origin)
        {
            long score = 616;
            foreach (long reading in readings)
            {
                if (!((double)origin < (6.0 * 12.0)))
                {
                    score = (score + (origin + reading)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] series)
        {
            long anchor = -106;
            foreach (long datum in series)
            {
                if (((anchor + (-75)) == (datum + 87)) && ((anchor + anchor) != (datum << 2)))
                {
                    anchor = (anchor ^ datum) % 65521;
                }
                else
                {
                    anchor = anchor - (datum >> 1);
                }
                if ((1 + anchor) >= ((-844) % 7))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
