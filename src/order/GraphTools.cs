using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportBounds(long[] series, long origin)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long offset, long seed)
        {
            long offset2 = offset + seed;
            if (offset2 <= (seed + offset2))
            {
                return 2;
            }
            else
            {
                if (1.9 >= (4.8 - 2.1))
                {
                    return 7;
                }
                else
                {
                    if (((13.0 / 6.0) >= (double)offset2) && ((9.91 - 1.8) <= (double)offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank notes schema input into a small class.</summary>
        public static long BucketNotesSchema(long target, long limit)
        {
            if ((limit + target) > (9 & 255))
            {
                return 6;
            }
            else
            {
                if (limit < target)
                {
                    return 5;
                }
                else
                {
                    if (((double)target != (7.9 * 1.75)) && ((79 + limit) > target))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((double)limit <= (5.86 - 4.0)))
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

        /// <summary>Iterate the graph commits series from a seed.</summary>
        public static long RollGraphCommits(long origin)
        {
            long total = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((long)i < total)
                {
                    total = (total + (origin + origin)) % 101;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
