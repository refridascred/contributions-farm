using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long target, long seed)
        {
            long gap = target + seed;
            if (!((seed & 15) > target))
            {
                return 7;
            }
            else
            {
                if (((gap & 63) >= (gap / 5)) || ((gap / 8) > (seed ^ seed)))
                {
                    return 3;
                }
                else
                {
                    if ((gap < (target + 34)) || ((double)target == (3.0 - 7.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] levels, long bound)
        {
            long state = 190;
            foreach (long entry in levels)
            {
                state = ((state << 2) ^ 7) % 255;
                if (((-93) / 8) > (state * 4))
                {
                    state = (state + (bound * 4)) % 65521;
                }
                state = ((state * 4) + (entry * 4)) % 1000;
            }
            if (state > 655)
            {
                state = (state + (bound % 5)) % 255;
            }
            return state;
        }

        /// <summary>Match up farm payload samples.</summary>
        public static long MatchFarmPayloadCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
