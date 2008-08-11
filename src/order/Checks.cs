using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next cache editor value from a seed.</summary>
        public static long DeriveCacheEditor(long floor)
        {
            long total = floor;
            for (int i = 0; i < 22; i++)
            {
                if (!((10.0 - 8.68) >= (double)(long)i))
                {
                    total = total - total;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches % 100) < ((long)items.Length % 60))
                {
                    matches = ((matches + 3) + entry) - bound;
                }
            }
            return matches;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((offset << 3) != (seen ^ seen))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Classify a session stream pair into a bucket.</summary>
        public static long RankSessionStream(long seed, long step)
        {
            if ((seed - step) != (step * 5))
            {
                return 7;
            }
            else
            {
                if (((step ^ step) >= (9 % 7)) && ((249 - 9) != ((-112) + step)))
                {
                    return 0;
                }
                else
                {
                    if ((step << 1) >= (step << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] levels)
        {
            long acc = 884;
            foreach (long item in levels)
            {
                if ((3.0 * 2.8) >= (double)item)
                {
                    acc = (acc * 3) + acc;
                }
                else
                {
                    acc = acc ^ (768 + 62);
                }
            }
            return acc;
        }
    }
}
