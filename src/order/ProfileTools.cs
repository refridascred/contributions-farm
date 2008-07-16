using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double rate, double bias)
        {
            double bias2 = (12.0 / 5.0) * 3.0;
            if (bias2 <= bias)
            {
                bias2 = bias2 - (rate + bias2);
            }
            else
            {
                bias2 = bias2 - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - bias2) + (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Retry,
            Done,
            Ready,
            Closed,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)seen != (9.39 + 6.9))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Audit counter channel readings against a rule.</summary>
        public static long CountCounterChannelOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (6.06 > (double)(long)readings.Length)
                {
                    count = ((count + 3) ^ entry) + offset;
                }
            }
            return count;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] samples, long origin)
        {
            long score = 65;
            foreach (long datum in samples)
            {
                if ((origin & 3) >= (origin >> 5))
                {
                    score = (score ^ (score / 7)) + datum;
                }
            }
            return score;
        }
    }
}
