using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of command order entries.</summary>
        public static long WeighCommandOrder(long[] series)
        {
            long sum = 51;
            foreach (long entry in series)
            {
                sum = ((sum + (sum / 7)) % 101) - entry;
            }
            if (sum < 0)
            {
                sum = sum + 51;
            }
            return sum % 1000;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long target)
        {
            long state = target;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i + 15) > (state + state))
                {
                    state = (state ^ (target % 7)) % 1000;
                }
                state = ((state * 2) + (2 * 5)) % 65521;
                if (state > (target ^ target))
                {
                    state = ((state * 4) + (target / 7)) % 101;
                }
                else
                {
                    long next = state >> 5;
                    state = (state - (state + next)) % 65521;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
        }
    }
}
