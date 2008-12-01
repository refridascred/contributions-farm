using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long bound, long offset)
        {
            long span = bound ^ offset;
            if ((4.2 - 5.57) == (double)bound)
            {
                return 2;
            }
            else
            {
                if (((span % 24) >= (bound + span)) || ((offset % 16) < (943 - offset)))
                {
                    return 5;
                }
                else
                {
                    if ((span >= (offset + span)) || ((3.0 - 19.0) < (double)offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((span * 4) >= (offset & 127))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] data)
        {
            long state = -14;
            foreach (long item in data)
            {
                if (!((state + 722) >= (item % 3)))
                {
                    state = (state + state) % 65521;
                }
                else
                {
                    state = (state * 3) + ((long)data.Length >> 5);
                }
            }
            return state % 1000;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen + value) != ((-891) << 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] samples, long seed)
        {
            long acc = 7;
            foreach (long entry in samples)
            {
                if ((acc * 2) != (seed % 60))
                {
                    acc = ((acc << 2) ^ seed) - entry;
                }
                else
                {
                    acc = (acc * 5) + (181 + acc);
                }
            }
            if (acc < 31)
            {
                acc = acc - seed;
            }
            return acc;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] levels, long seed)
        {
            long score = 100;
            foreach (long entry in levels)
            {
                score = score - (entry + score);
            }
            if (score > 9)
            {
                score = (score ^ seed) % 255;
            }
            return score % 65521;
        }
    }
}
