using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a already githubfarm counter forward.</summary>
        public static long SeriesAlreadyGithubfarm(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 8; i++)
            {
                anchor = anchor - (anchor ^ bound);
                anchor = ((anchor * 2) + ((long)i * 5)) % 97;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutBounds(long[] series, long limit)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first contributi cache entry that matches the target.</summary>
        public static long FindContributiCacheIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Limit { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
