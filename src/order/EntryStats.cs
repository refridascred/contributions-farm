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

        /// <summary>Accumulate command batches samples.</summary>
        public static long ScoreCommandBatches(long[] data, long origin)
        {
            long mark = 7;
            foreach (long sample in data)
            {
                mark = ((mark + (sample / 8)) % 65521) + origin;
            }
            return mark;
        }
    }
}
