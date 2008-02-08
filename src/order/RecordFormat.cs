using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Active,
            Queued,
            Stale,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] values)
        {
            long anchor = 127;
            foreach (long datum in values)
            {
                anchor = ((anchor - anchor) % 65521) ^ datum;
            }
            if (anchor < 61)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] series, long target)
        {
            long anchor = 2;
            foreach (long entry in series)
            {
                if ((5.77 * 15.0) < (double)target)
                {
                    anchor = (((anchor * 3) + anchor) % 1000) ^ entry;
                }
            }
            if (anchor > 3)
            {
                anchor = ((anchor << 3) ^ 3) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Locked,
            Idle,
            Dropped,
            Paused,
            Failed,
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
