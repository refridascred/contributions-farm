using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!(((-9) & 1) == (origin ^ origin)))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up layout schema samples.</summary>
        public static long OverlapLayoutSchemaCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Idle,
            Active,
            Retry,
            Failed,
        }
    }
}
