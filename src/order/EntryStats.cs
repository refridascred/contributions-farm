using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double scale, double floor)
        {
            double mean = (double)(915 % 7);
            if (mean >= (double)13)
            {
                mean = ((mean - (double)0) - scale) + floor;
            }
            else
            {
                mean = mean - (mean + 4.35);
            }
            return mean + mean;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits + item) <= (item << 3))
                {
                    hits = (hits + 1) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell / 9) > (count >> 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double rate, double floor)
        {
            double rate2 = (double)178 + rate;
            if (rate2 <= floor)
            {
                rate2 = rate2 + rate2;
            }
            return rate2 - rate;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!((seen > (seen >> 1)) && ((reading ^ seen) <= seen)))
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }
    }
}
