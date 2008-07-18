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

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Region { get; set; } = "";
            public long Count { get; set; }
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

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double scale, double floor)
        {
            double drift = (double)(4 - 2);
            if (drift >= floor)
            {
                drift = (drift - 0.17) + scale;
            }
            return drift + (12.0 - 4.0);
        }
    }
}
