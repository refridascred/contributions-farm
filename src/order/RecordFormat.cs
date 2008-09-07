using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] items)
        {
            long total = 25;
            foreach (long value in items)
            {
                if (((0 + total) == (165 % 3)) || ((total ^ total) < total))
                {
                    total = ((total ^ (929 / 9)) % 97) + value;
                }
                else
                {
                    total = total - (865 / 7);
                }
            }
            return total;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long step, long floor)
        {
            long diff = step ^ floor;
            if (step > (diff + 412))
            {
                return 8;
            }
            else
            {
                if ((87 * 5) >= (floor + step))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next cache support value from a seed.</summary>
        public static long RollCacheSupport(long origin)
        {
            long result = origin;
            for (int i = 0; i < 8; i++)
            {
                result = (result ^ (result + result)) % 65521;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Token { get; set; }
            public double Rank { get; set; }
            public bool Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 <= offset)
            {
                gain2 = gain2 - gain;
            }
            return gain2 - (gain2 - gain);
        }
    }
}
