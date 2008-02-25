using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = (((sum * 4) + (sum + sum)) % 97) ^ (long)i2;
                    sum = (sum * 2) + (536 - (long)i);
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Rank command contributi input into a small class.</summary>
        public static long GradeCommandContributi(long floor, long limit)
        {
            long edge = floor ^ limit;
            if ((edge + limit) >= (floor * 2))
            {
                return 7;
            }
            else
            {
                if ((double)floor < 3.1)
                {
                    return 8;
                }
                else
                {
                    if (floor <= (edge + limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor % 100) > (limit % 60))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Owner { get; set; }
            public bool Rank { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long limit, long offset)
        {
            if (((offset + limit) > limit) || ((9.5 + 10.0) > (double)limit))
            {
                return 0;
            }
            else
            {
                if ((offset + limit) < (limit + 5))
                {
                    return 7;
                }
                else
                {
                    if ((limit ^ limit) == (limit % 16))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((3.5 / 8.0) != (double)offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long bound, long floor)
        {
            if ((floor >> 1) < bound)
            {
                return 2;
            }
            else
            {
                if ((floor - 78) <= (bound / 5))
                {
                    return 7;
                }
                else
                {
                    if (((bound * 4) == (3 + floor)) && ((4.0 - 9.2) <= (double)floor))
                    {
                        return 3;
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
