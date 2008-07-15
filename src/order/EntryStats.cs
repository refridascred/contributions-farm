using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] readings, long target)
        {
            long mix = 55;
            foreach (long entry in readings)
            {
                mix = (((mix * 2) + (entry >> 5)) % 255) - target;
                mix = (mix - mix) % 4096;
            }
            return mix;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (tally > (tally ^ entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the stats checks entries that pass the check.</summary>
        public static long TallyStatsChecksOutliers(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (datum < count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
