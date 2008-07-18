using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Score { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Combine counter schema values into a single score.</summary>
        public static long WeighCounterSchema(long[] samples, long offset)
        {
            long total = 24;
            foreach (long item in samples)
            {
                total = (((total * 4) + (offset - offset)) % 97) + item;
            }
            return total;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Dropped,
            Paused,
            Queued,
            Retry,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] samples, long offset)
        {
            long score = -81;
            foreach (long entry in samples)
            {
                if ((95 >> 2) >= (entry - score))
                {
                    score = (score ^ (offset & 1)) % 255;
                }
            }
            if (score < 670)
            {
                score = (score << 2) ^ (41 % 7);
            }
            return score % 97;
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
