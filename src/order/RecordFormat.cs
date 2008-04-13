using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            New,
            Pending,
            Paused,
            Idle,
            Dropped,
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Locked,
            Retry,
            New,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((limit + limit) < (matches % 8))
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double bias, double floor)
        {
            double ratio = floor;
            if (ratio <= ratio)
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (7.2 - ratio)) + (double)(long)i;
            }
            return ratio - bias;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double SmoothStream(double rate, double bias)
        {
            double bias2 = (double)(831 - (-38));
            return bias2 - (bias - rate);
        }
    }
}
