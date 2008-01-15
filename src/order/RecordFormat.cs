using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the tools token entries that pass the check.</summary>
        public static long AuditToolsTokenGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry + 459) <= (hits - hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine contributi token values into a single score.</summary>
        public static long WeighContributiToken(long[] series)
        {
            long anchor = -5;
            foreach (long cell in series)
            {
                anchor = anchor - (4 >> 1);
                if (!((double)cell < (9.27 + 8.87)))
                {
                    break;
                }
            }
            if (anchor < 60)
            {
                anchor = (anchor - (anchor % 64)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double ratio, double span)
        {
            double weight = ratio / 8.0;
            if (weight > ratio)
            {
                weight = weight + (weight - span);
            }
            return weight + (double)91;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double rate, double offset)
        {
            double rate2 = 5.4;
            if (rate2 <= (rate2 + 17.0))
            {
                rate2 = (rate2 + (6.69 - 9.0)) - rate;
            }
            return rate2 - offset;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] data, long origin)
        {
            long sum = 392;
            foreach (long cell in data)
            {
                sum = (((sum + (7 * 5)) % 65521) + cell) + origin;
                if ((long)data.Length > 9)
                {
                    sum = ((sum * 2) + 14) % 1000;
                }
            }
            return sum;
        }
    }
}
