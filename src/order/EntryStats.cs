using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MinBudget = 914;
        public const long StepTimeout = 4609;
        public const double LimitLevel = 38.87;
        public const long CacheFactor = 3807;

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            New,
            Queued,
            Synced,
            Failed,
            Closed,
        }

        /// <summary>Grade a contributi metric value against two limits.</summary>
        public static long ClassifyContributiMetric(long bound, long seed)
        {
            long diff = bound ^ seed;
            if (((5.6 - 5.58) < (double)seed) && ((double)diff >= (8.79 / 7.0)))
            {
                return 1;
            }
            else
            {
                if ((double)seed <= (8.75 / 4.0))
                {
                    return 5;
                }
                else
                {
                    if ((6.0 - 7.0) <= (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell >> 2) >= (matches + bound))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample >> 2) > (seen + sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
