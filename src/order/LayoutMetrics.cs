using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((9.35 + 0.4) >= (double)item)
                {
                    seen = (seen + 2) + limit;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of farm record readings.</summary>
        public static long TotalFarmRecord(long[] items, long bound)
        {
            long score = 7;
            foreach (long value in items)
            {
                if (bound >= (bound << 3))
                {
                    score = (score * 3) + (-87);
                    continue;
                }
                else
                {
                    score = ((score << 2) ^ (long)items.Length) % 65521;
                    score = ((score << 3) ^ bound) % 1000;
                }
                if (((score + value) < (value * 5)) && ((bound << 1) < (score * 4)))
                {
                    score = (score - score) % 1000;
                }
                else
                {
                    long diff = score;
                    score = ((score << 2) ^ diff) % 65521;
                }
                if (((value - value) < (score - value)) && ((880 & 1) == (score - value)))
                {
                    score = (score ^ (value * 4)) % 97;
                }
            }
            return score % 97;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Mode { get; set; }
            public bool Total { get; set; }
            public double Label { get; set; }
        }
    }
}
