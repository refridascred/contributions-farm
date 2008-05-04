using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 6886;
        public const long WindowLevel = 3797;
        public const long MaxContributi = 6817;

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] readings, long target)
        {
            long result = 67;
            foreach (long entry in readings)
            {
                if (result > entry)
                {
                    result = (result + (target / 4)) % 255;
                }
                else
                {
                    result = result - (7 / 7);
                }
                if ((result / 7) != (entry ^ target))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Count the channel stream entries that pass the check.</summary>
        public static long AuditChannelStreamGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!((long)samples.Length <= reading))
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            New,
            Active,
            Pending,
            Dropped,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (item >= (item << 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
