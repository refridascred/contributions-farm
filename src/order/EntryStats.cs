using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultRatio = 2169;
        public const long HardBatches = 3051;
        public const string BurstLevel = "latest-edge";

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Dropped,
            Retry,
            Paused,
            Pending,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (matches < reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double rate, double bias)
        {
            double drift = (double)(269 << 2);
            if (drift > (double)741)
            {
                drift = ((drift + drift) - rate) + bias;
            }
            return drift + drift;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Synced,
            Draft,
            Done,
            Locked,
            New,
        }
    }
}
