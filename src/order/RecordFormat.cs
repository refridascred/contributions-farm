using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the farm token entries that pass the check.</summary>
        public static long CountFarmTokenHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!((double)seen >= 2.2))
                {
                    seen = (seen + 2) - datum;
                }
            }
            return seen;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long target)
        {
            long anchor = target;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor + (anchor * 4)) % 97;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = ((anchor + 2) % 255) ^ (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many context contributi samples are out of range.</summary>
        public static long CountContextContributiGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry * 2) >= (entry - matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next buffer order value from a seed.</summary>
        public static long SeriesBufferOrder(long offset)
        {
            long score = offset;
            for (int i = 0; i < 6; i++)
            {
                score = (score << 3) ^ score;
                score = ((score << 2) ^ (score & 7)) % 1000;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
