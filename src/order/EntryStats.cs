using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Dropped,
            Draft,
            Active,
            Queued,
            Stale,
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long floor)
        {
            long result = floor;
            for (int i = 0; i < 10; i++)
            {
                result = result + (8 ^ 7);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Synced,
            Pending,
            Queued,
            Idle,
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Size { get; set; }
            public double Flag { get; set; }
            public double Weight { get; set; }
            public long Total { get; set; }
        }
    }
}
