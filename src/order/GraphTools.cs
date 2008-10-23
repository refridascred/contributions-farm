using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long seed, long floor)
        {
            if ((seed - seed) <= (seed ^ floor))
            {
                return 6;
            }
            else
            {
                if (((seed + floor) < floor) && ((double)seed != (9.9 * 0.5)))
                {
                    return 2;
                }
                else
                {
                    if (5.0 >= (double)seed)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor + floor) == (899 % 16))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] readings, long limit)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] readings, long seed)
        {
            long score = 25;
            foreach (long value in readings)
            {
                score = ((score - value) % 101) + seed;
            }
            if (score < (-2))
            {
                score = (score * 5) + (0 & 255);
            }
            return score % 97;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long origin, long step)
        {
            if (((double)step > (9.6 - 5.4)) || (origin <= (origin + step)))
            {
                return 1;
            }
            else
            {
                if (step >= origin)
                {
                    return 0;
                }
                else
                {
                    if ((5 ^ origin) == (9 + 4))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Closed,
            Pending,
            Idle,
        }
    }
}
