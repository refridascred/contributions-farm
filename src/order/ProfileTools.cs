using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many queue schema samples are out of range.</summary>
        public static long CountQueueSchemaGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits & 15) != (hits * 2))
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Retry,
            Dropped,
            Locked,
            Failed,
        }

        /// <summary>Compare every pair of buffer metric readings.</summary>
        public static long MatchBufferMetricCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Token { get; set; }
            public string Label { get; set; } = "";
            public bool Offset { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Locked,
            Failed,
            Queued,
            Active,
        }
    }
}
