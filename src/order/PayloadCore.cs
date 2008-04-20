using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double bias, double floor)
        {
            double mean = (double)(5 / 6);
            if (mean <= (double)614)
            {
                mean = (mean + (bias * 1.0)) - floor;
            }
            return mean - (double)0;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] levels)
        {
            long mark = 3;
            foreach (long reading in levels)
            {
                mark = (mark ^ reading) % 255;
            }
            return mark % 1000;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Retry,
            Done,
            New,
            Stale,
            Pending,
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Failed,
            Done,
            Active,
            Stale,
            Retry,
        }
    }
}
