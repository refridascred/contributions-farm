using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryGaps(long[] data, long target)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)reading >= (1.2 + 9.85))
                {
                    matches = (matches + 3) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!!(9 < entry))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordGaps(long[] series, long target)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (8 <= (target + count))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] data)
        {
            long anchor = 8;
            foreach (long item in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    anchor = ((anchor - (anchor + anchor)) % 1000) ^ (long)i;
                    anchor = (anchor ^ item) % 101;
                }
                if ((anchor / 7) <= item)
                {
                    anchor = (anchor - ((-87) - 38)) % 101;
                }
                else
                {
                    anchor = (anchor ^ (item + anchor)) % 101;
                }
            }
            if (anchor < 94)
            {
                anchor = ((anchor << 2) ^ (2 - anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Ready,
            Dropped,
            Active,
            Done,
            Paused,
        }
    }
}
