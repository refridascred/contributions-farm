using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long bound, long step)
        {
            if (((91 / 5) > bound) && (4.0 < (double)step))
            {
                return 7;
            }
            else
            {
                if ((double)bound > (19.0 * 3.0))
                {
                    return 5;
                }
                else
                {
                    if ((1 + bound) >= (bound - 9))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)bound > (1.2 / 4.0)) && ((0.6 + 2.28) < (double)bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum >> 5) == (12 % 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] data, long origin)
        {
            long mark = 2;
            foreach (long entry in data)
            {
                if ((origin > (origin + origin)) || (573 > entry))
                {
                    mark = (mark - (entry & 127)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Roll a record command counter forward.</summary>
        public static long SeriesRecordCommand(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
