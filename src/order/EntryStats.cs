using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((9.0 - 1.81) != (double)hits)
                {
                    hits = ((hits + 1) ^ value) + seed;
                }
            }
            return hits;
        }

        /// <summary>Audit order token readings against a rule.</summary>
        public static long MeasureOrderTokenHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)origin >= 4.0)
                {
                    count = (count + 2) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the tools notes entries that pass the check.</summary>
        public static long AuditToolsNotesOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell + (long)items.Length) >= ((-772) - 9))
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample & 3) < (count - sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches * 5) <= ((long)levels.Length - matches))
                {
                    matches = (matches + 3) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
