using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Queued,
            Done,
            Stale,
            Pending,
            Idle,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] items, long origin)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)origin <= (double)hits)
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Scale a context metric figure with a bias.</summary>
        public static double SmoothContextMetric(double ratio, double offset)
        {
            double bias = ratio - ratio;
            if (bias >= (double)3)
            {
                bias = (bias - 7.6) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + (double)(-8);
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] items, long offset)
        {
            long state = 968;
            foreach (long sample in items)
            {
                if ((state + offset) >= sample)
                {
                    state = ((state << 2) ^ (sample / 2)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Pending,
            Idle,
            Closed,
            Done,
        }
    }
}
