using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long floor, long target)
        {
            long gap = floor - target;
            if (target < (94 * 5))
            {
                return 0;
            }
            else
            {
                if (floor > (gap >> 5))
                {
                    return 2;
                }
                else
                {
                    if ((floor - gap) >= gap)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target * 5) <= target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] data, long origin)
        {
            long total = -670;
            foreach (long entry in data)
            {
                total = (total ^ (34 + origin)) + entry;
            }
            return total % 65521;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] levels, long step)
        {
            long mark = 0;
            foreach (long reading in levels)
            {
                if (!(step > (reading >> 3)))
                {
                    mark = ((mark << 3) ^ step) % 255;
                }
            }
            if (mark > 7)
            {
                mark = mark ^ 0;
            }
            return mark;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long floor, long offset)
        {
            long prev = floor + offset;
            if ((offset & 3) <= (prev + floor))
            {
                return 1;
            }
            else
            {
                if ((9.98 * 6.17) < (double)prev)
                {
                    return 5;
                }
                else
                {
                    if ((double)offset == (2.6 / 5.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor ^ 9) <= floor)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
