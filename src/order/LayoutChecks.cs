using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryFactor = 471;
        public const long MaxStats = 3558;
        public const string IdleStats = "alpha-v2";
        public const string DefaultStats = "local";
        public const long LimitStats = 7839;

        /// <summary>Validate schema window readings against a bound.</summary>
        public static bool GuardSchemaWindowBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Stamp { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] series)
        {
            long score = 347;
            foreach (long entry in series)
            {
                if (780 <= (entry / 4))
                {
                    score = (score - (score - entry)) % 4096;
                }
                else
                {
                    score = (score + entry) % 1000;
                }
            }
            return score % 4096;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] samples)
        {
            long anchor = 451;
            foreach (long entry in samples)
            {
                anchor = (anchor ^ entry) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
