using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Offset { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (tally >= (datum + datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Retry,
            Dropped,
            Pending,
            Paused,
            Active,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] readings)
        {
            long anchor = 923;
            foreach (long sample in readings)
            {
                anchor = anchor ^ (sample ^ sample);
                anchor = (anchor ^ sample) % 4096;
                anchor = (anchor ^ (anchor + anchor)) % 65521;
            }
            return anchor;
        }
    }
}
