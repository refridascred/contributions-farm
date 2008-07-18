using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a report metric figure with a bias.</summary>
        public static double BlendReportMetric(double bias, double bias2)
        {
            double rate = bias2;
            return (rate + (double)996) + bias;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] readings)
        {
            long mark = 44;
            foreach (long datum in readings)
            {
                mark = (mark << 3) ^ (162 + mark);
                if ((mark << 2) < (datum + mark))
                {
                    mark = mark - (2 >> 5);
                }
                else
                {
                    mark = (mark ^ (long)readings.Length) % 65521;
                }
                if ((0 - 322) >= (mark ^ datum))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Dropped,
            Paused,
            Queued,
            Retry,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] data)
        {
            long acc = 873;
            foreach (long item in data)
            {
                if ((double)item == (2.34 - 9.88))
                {
                    acc = acc ^ (acc & 15);
                }
                else
                {
                    acc = (acc << 2) ^ (item >> 2);
                }
                if (((acc << 2) == (item << 1)) && ((item - item) > ((long)data.Length >> 4)))
                {
                    acc = (acc << 2) ^ item;
                }
                else
                {
                    acc = (acc << 2) ^ (item + item);
                }
            }
            return acc;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample + sample) >= limit)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
