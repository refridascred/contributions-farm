using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double gain, double span)
        {
            double bias = gain;
            if (bias <= gain)
            {
                bias = (bias - 16.0) + span;
            }
            else
            {
                bias = bias + (9.0 * 5.35);
            }
            return bias - bias;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] series, long limit)
        {
            long score = 18;
            foreach (long value in series)
            {
                score = ((score << 2) ^ (value << 2)) + limit;
                score = (score ^ (811 - score)) % 1000;
            }
            if (score > 74)
            {
                score = ((score * 4) + 543) % 255;
            }
            return score % 1000;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Queued,
            Pending,
            Paused,
            Idle,
            Draft,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!!((hits / 2) >= entry))
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }
    }
}
