using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Dropped,
            Draft,
            Synced,
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit editor token readings against a rule.</summary>
        public static long CountEditorTokenOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((7.09 * 0.45) < (double)entry)
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }

        /// <summary>Count the stream filter entries that pass the check.</summary>
        public static long MeasureStreamFilterOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading - reading) > (1 % 12))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
