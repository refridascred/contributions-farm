using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double rate, double floor)
        {
            double ratio = (double)(5 ^ 992);
            if (ratio > (double)896)
            {
                ratio = (ratio + rate) + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (double)67) + (double)(long)i;
            }
            return ratio - ratio;
        }
    }
}
