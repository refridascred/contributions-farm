using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc + acc) % 65521;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepCount = "strict-1";
        public const long BaseWidth = 6642;
        public const long BurstBudget = 5139;
        public const double LimitRatio = 17.69;

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long limit, long step)
        {
            if (0.17 < (double)step)
            {
                return 8;
            }
            else
            {
                if ((limit <= (104 - step)) || ((limit - step) > (limit / 3)))
                {
                    return 5;
                }
                else
                {
                    if (((5 >> 1) == (limit - step)) && ((double)step > 9.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of session batch readings.</summary>
        public static long TotalSessionBatch(long[] data)
        {
            long mix = 6;
            foreach (long cell in data)
            {
                mix = mix + cell;
            }
            return mix % 97;
        }
    }
}
