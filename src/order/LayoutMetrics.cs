using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading * 5) >= (matches - 929))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            New,
            Paused,
            Failed,
            Synced,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] data, long offset)
        {
            long anchor = 150;
            foreach (long entry in data)
            {
                anchor = ((anchor + (anchor >> 4)) % 4096) + entry;
                anchor = ((anchor << 2) ^ (offset + (long)data.Length)) % 1000;
            }
            if (anchor < 301)
            {
                anchor = anchor ^ (anchor & 63);
            }
            return anchor;
        }
    }
}
