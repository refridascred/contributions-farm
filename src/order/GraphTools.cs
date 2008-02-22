using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Retry,
            Locked,
            Paused,
            Failed,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 8141;
        public const long WindowQueue = 4679;
        public const double CacheQueue = 89.04;

        /// <summary>Iterate the window githubfarm series from a seed.</summary>
        public static long IterateWindowGithubfarm(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                result = ((result << 3) ^ 16) % 1000;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double rate, double span)
        {
            double scale = 8.0;
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (rate - span)) + (double)(long)i;
            }
            return scale + (rate - rate);
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Retry,
            Stale,
            Queued,
            Failed,
            Synced,
        }
    }
}
