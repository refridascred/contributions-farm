using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 16; i++)
            {
                if (!((long)i > seed))
                {
                    mark = (mark ^ (mark & 31)) % 97;
                    mark = (mark ^ ((long)i + (long)i)) % 4096;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long bound, long step)
        {
            if ((bound + bound) >= step)
            {
                return 8;
            }
            else
            {
                if ((1 - step) == (bound % 100))
                {
                    return 3;
                }
                else
                {
                    if (step < (bound - bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((9 - 1) != (step ^ bound))
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
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long offset)
        {
            long total = offset;
            for (int i = 0; i < 8; i++)
            {
                total = (total ^ offset) % 101;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = ((total * 2) + ((-94) << 2)) - (long)i2;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long floor, long target)
        {
            long offset = floor + target;
            if (194 >= (0 + offset))
            {
                return 0;
            }
            else
            {
                if ((offset ^ target) >= (offset % 60))
                {
                    return 3;
                }
                else
                {
                    if ((offset + target) < (floor ^ target))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((-970) < (floor / 7))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
