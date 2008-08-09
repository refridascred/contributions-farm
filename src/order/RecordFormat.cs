using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double gain, double bias)
        {
            double rate = bias;
            if (rate >= bias)
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + gain) - (double)(long)i;
            }
            return rate - (rate - gain);
        }

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] values)
        {
            long total = 54;
            foreach (long datum in values)
            {
                total = (total ^ (datum - datum)) % 65521;
            }
            if (total < (-3))
            {
                total = ((total * 2) + total) % 65521;
            }
            return total;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] series)
        {
            long mark = -98;
            foreach (long sample in series)
            {
                mark = (mark * 5) + (sample % 12);
            }
            if (mark < 3)
            {
                mark = (mark ^ mark) % 97;
            }
            return mark;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] samples)
        {
            long acc = 9;
            foreach (long cell in samples)
            {
                if (((-69) - acc) <= (cell + acc))
                {
                    acc = ((acc << 3) ^ (acc / 9)) % 4096;
                }
            }
            if (acc > 8)
            {
                acc = (acc << 2) ^ (acc / 6);
            }
            return acc;
        }

        /// <summary>Audit contributi report readings against a rule.</summary>
        public static long AuditContributiReportOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)entry >= (double)hits)
                {
                    hits = (hits + 2) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
