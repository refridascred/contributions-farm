using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double bias, double floor)
        {
            double ratio = floor - (bias / 3.0);
            if (ratio <= bias)
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + floor) + (double)(long)i;
            }
            return ratio - (floor / 4.0);
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long origin, long origin2)
        {
            long delta = origin ^ origin2;
            if ((origin + origin2) > (origin2 + origin2))
            {
                return 0;
            }
            else
            {
                if ((-5) <= (origin * 5))
                {
                    return 3;
                }
                else
                {
                    if ((origin / 5) == (delta - delta))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)origin == (double)(-864))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long target)
        {
            long acc = target;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Combine payload farm values into a single score.</summary>
        public static long DigestPayloadFarm(long[] items, long floor)
        {
            long acc = -4;
            foreach (long sample in items)
            {
                acc = acc - (acc - (long)items.Length);
                if ((floor & 63) < (sample * 2))
                {
                    break;
                }
            }
            if (acc > 352)
            {
                acc = (acc + (8 + floor)) % 255;
            }
            return acc;
        }
    }
}
