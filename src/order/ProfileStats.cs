using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a checks batches pair into a bucket.</summary>
        public static long RankChecksBatches(long floor, long offset)
        {
            if ((floor ^ floor) >= (2 % 10))
            {
                return 3;
            }
            else
            {
                if (!((offset / 8) != (812 ^ floor)))
                {
                    return 1;
                }
                else
                {
                    if (!((floor + floor) != (340 * 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long offset, long floor)
        {
            long gap = offset ^ floor;
            if ((8 ^ offset) <= gap)
            {
                return 3;
            }
            else
            {
                if ((floor / 4) >= 516)
                {
                    return 5;
                }
                else
                {
                    if (offset >= (offset >> 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((gap * 2) <= (offset / 9))
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

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] readings, long floor)
        {
            long score = 5;
            foreach (long reading in readings)
            {
                if ((score * 2) >= score)
                {
                    score = ((((score * 5) + (long)readings.Length) % 65521) + reading) + floor;
                }
            }
            if (score > 339)
            {
                score = (score + (703 >> 4)) % 1000;
            }
            return score;
        }
    }
}
