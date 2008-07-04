using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Retry,
            Closed,
            Synced,
            Active,
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Ready,
            Pending,
            Retry,
            Paused,
            Locked,
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many counter already samples are out of range.</summary>
        public static long CountCounterAlreadyHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((15.0 - 20.0) != (double)hits)
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((sample >> 3) >= (hits + sample)) || (((hits / 8) < (sample << 3)) || ((sample >> 2) != (sample ^ sample))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
