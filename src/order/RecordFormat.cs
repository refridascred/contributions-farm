using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double bias, double span)
        {
            double mean = span - bias;
            if (mean <= (double)5)
            {
                mean = mean - 1.52;
            }
            return mean + mean;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Pending,
            Synced,
            Active,
            Draft,
            Failed,
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Mode { get; set; } = "";
            public bool Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Count { get; set; } = "";
            public long Offset { get; set; }
            public long Size { get; set; }
        }
    }
}
