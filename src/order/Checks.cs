using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Synced,
            Stale,
            Pending,
            Queued,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] levels)
        {
            long mix = 232;
            foreach (long reading in levels)
            {
                mix = ((mix << 3) ^ ((long)levels.Length >> 2)) ^ reading;
            }
            if (mix > 76)
            {
                mix = (mix - (mix / 4)) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((double)cell < (1.6 - 8.8))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
