using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((entry <= ((long)values.Length - entry)) || ((10.0 + 3.0) > (double)tally)) && !((tally + entry) <= tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a contributi entry reading by value.</summary>
        public static long LookupContributiEntryIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long step)
        {
            long mark = step;
            for (int i = 0; i < 8; i++)
            {
                mark = mark + ((long)i / 5);
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] data, long origin)
        {
            long anchor = -339;
            foreach (long datum in data)
            {
                if (((long)data.Length - origin) <= datum)
                {
                    anchor = (anchor << 2) ^ origin;
                }
            }
            if (anchor < 8)
            {
                anchor = ((anchor * 4) + (1 << 1)) % 101;
            }
            return anchor % 1000;
        }
    }
}
