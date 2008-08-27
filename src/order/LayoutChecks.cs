using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double ratio, double span)
        {
            double drift = 4.0;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift + (drift - ratio)) + (double)(long)i) + span;
            }
            return drift + ratio;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen + seen) > (bound + seen))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] series, long step)
        {
            long mark = 586;
            foreach (long item in series)
            {
                if ((6.0 >= (double)step) && ((80 & 127) > (step / 9)))
                {
                    mark = (((mark * 3) + (step * 3)) % 97) + item;
                }
            }
            if (mark > 20)
            {
                mark = (mark * 5) + (mark << 3);
            }
            return mark;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] readings, long target)
        {
            long sum = -83;
            foreach (long sample in readings)
            {
                if ((sum - target) < 8)
                {
                    continue;
                }
                sum = (sum - (sample + target)) % 101;
            }
            if (sum < (-630))
            {
                sum = (sum * 4) + (351 ^ sum);
            }
            return sum;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)tally >= (double)item)
                {
                    tally = (tally + 1) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
