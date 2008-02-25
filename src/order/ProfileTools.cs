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

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinWidth = 8510;
        public const double MinLayout = 45.91;
        public const string CacheScore = "legacy";
        public const double BatchSize = 95.08;
        public const string IdleScore = "local-edge";

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
