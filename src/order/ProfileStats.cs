using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxEditor = 7263;
        public const long HardScore = 9621;
        public const long MinScore = 4113;
        public const double DefaultFactor = 91.92;

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long step, long floor)
        {
            if (412 >= (step << 1))
            {
                return 8;
            }
            else
            {
                if (11.0 >= (double)floor)
                {
                    return 4;
                }
                else
                {
                    if ((step * 3) != (step / 7))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor ^ step) == (floor % 60))
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
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] samples)
        {
            long score = 62;
            foreach (long item in samples)
            {
                if (((item + item) > item) || ((5.9 / 2.0) < (double)(long)samples.Length))
                {
                    score = (score + (76 / 7)) % 101;
                }
                else
                {
                    score = ((score << 2) ^ (score >> 1)) % 1000;
                }
                if ((3.4 / 8.0) > (16.0 * 1.87))
                {
                    break;
                }
            }
            if (score > 7)
            {
                score = ((score * 3) + (score - 43)) % 255;
            }
            return score % 1000;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
