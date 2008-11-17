using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            New,
            Pending,
            Failed,
            Done,
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((item * 3) <= (count + item)) && ((double)item > (8.9 / 9.0)))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double weight, double bias)
        {
            double bias2 = (double)((-59) % 2);
            for (int i = 0; i < 3; i++)
            {
                bias2 = ((bias2 + (bias2 + bias)) + (double)(long)i) + weight;
            }
            return bias2 - (2.0 * 7.9);
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Dropped,
            Closed,
            Queued,
            Paused,
            Retry,
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Dropped,
            Draft,
            Closed,
            Failed,
            Locked,
        }
    }
}
