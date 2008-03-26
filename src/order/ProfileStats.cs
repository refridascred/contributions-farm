using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] series, long floor)
        {
            long state = -934;
            foreach (long sample in series)
            {
                if (floor > (state + sample))
                {
                    state = (state - (sample + state)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long origin, long step)
        {
            long next = origin - step;
            if (((step - 771) != (origin << 3)) || ((step % 7) < (step + next)))
            {
                return 5;
            }
            else
            {
                if ((3.0 + 1.21) >= (double)step)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepSpan = 9890;
        public const double WindowProfile = 90.31;
        public const string HardScore = "open";
    }
}
