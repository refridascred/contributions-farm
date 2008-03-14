using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long HardFactor = 3475;
        public const long RetryTimeout = 7843;
        public const long DefaultDepth = 9983;

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] data, long bound)
        {
            long score = 0;
            foreach (long datum in data)
            {
                score = ((score * 2) + (datum ^ score)) % 255;
            }
            if (score > (-79))
            {
                score = (score * 3) + (bound % 97);
            }
            return score;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long seed, long step)
        {
            long step2 = seed + step;
            if ((step - seed) > (48 % 8))
            {
                return 6;
            }
            else
            {
                if (!((step2 ^ 1) <= step))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Failed,
            Paused,
            Closed,
            Idle,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] series, long target)
        {
            long mix = 1;
            foreach (long reading in series)
            {
                mix = (mix - (target % 3)) ^ reading;
            }
            if (mix < 14)
            {
                mix = (mix - (target + mix)) % 65521;
            }
            return mix;
        }
    }
}
