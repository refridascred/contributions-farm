using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Pending,
            Stale,
            Dropped,
            Queued,
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Level { get; set; } = "";
            public long Limit { get; set; }
            public double Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Project the next record route value.</summary>
        public static double AdjustRecordRoute(double scale, double offset)
        {
            double mean = (double)(4 % 16);
            if (mean < offset)
            {
                mean = mean - (double)5;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (scale - scale)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((double)value > (double)(long)data.Length)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
