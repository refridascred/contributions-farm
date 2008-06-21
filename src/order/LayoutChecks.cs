using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (cell > (cell >> 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double rate, double bias)
        {
            double bias2 = rate;
            if (bias2 > 9.01)
            {
                bias2 = (bias2 - (double)(-81)) + bias;
            }
            return bias2 - (bias2 / 5.0);
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Queued,
            Idle,
            Paused,
            Dropped,
            Retry,
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Limit { get; set; }
            public double Rank { get; set; }
            public long Total { get; set; }
        }
    }
}
