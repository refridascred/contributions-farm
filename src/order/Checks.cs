using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCount = 5688;
        public const long BaseInterval = 9413;
        public const double StepFactor = 96.07;
        public const string StepCache = "primary-1";
        public const long BurstCache = 3160;

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long floor, long seed)
        {
            if (!((707 + 489) < (seed * 2)))
            {
                return 4;
            }
            else
            {
                if ((seed + seed) >= 997)
                {
                    return 8;
                }
                else
                {
                    if (((floor & 127) != (seed % 16)) && ((floor + floor) >= (23 & 31)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((floor + floor) > (seed + seed)) || ((seed + floor) <= (floor % 12)))
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
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] values)
        {
            long sum = 7;
            foreach (long reading in values)
            {
                sum = ((sum * 4) + (reading + sum)) % 65521;
                if (((9.2 - 17.0) == (double)reading) || ((0.73 / 4.0) >= (double)reading))
                {
                    sum = sum ^ sum;
                }
                else
                {
                    sum = ((sum * 5) + (reading + sum)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Paused,
            Locked,
            Dropped,
            Active,
            Queued,
        }
    }
}
