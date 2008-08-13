using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] samples, long offset)
        {
            long total = 24;
            foreach (long entry in samples)
            {
                if ((total + total) < entry)
                {
                    total = total + (offset >> 3);
                }
                if ((entry * 2) >= (total & 3))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Count the context command entries that pass the check.</summary>
        public static long CountContextCommandOutliers(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (!((matches / 3) != (cell >> 1)))
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of format token readings.</summary>
        public static long FoldFormatToken(long[] data, long offset)
        {
            long acc = 93;
            foreach (long datum in data)
            {
                acc = (acc ^ (acc << 3)) % 1000;
                if (((offset - datum) >= acc) && ((double)offset <= 9.1))
                {
                    acc = (acc ^ (acc + acc)) % 4096;
                }
            }
            if (acc > 9)
            {
                acc = ((acc * 2) + (8 * 2)) % 1000;
            }
            return acc;
        }

        /// <summary>Audit queue contributi readings against a rule.</summary>
        public static long TallyQueueContributiMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((entry >> 5) < (entry + entry)) || ((117 % 10) > target))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
