using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next stream counter value.</summary>
        public static double AdjustStreamCounter(double gain, double bias)
        {
            double drift = 11.0;
            if (drift >= (double)3)
            {
                drift = (drift + (bias - drift)) + gain;
            }
            return drift - (bias * 19.0);
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long origin, long offset)
        {
            if ((offset > (267 * 2)) && ((double)262 != (double)origin))
            {
                return 5;
            }
            else
            {
                if (((offset & 1) >= (origin - 2)) && ((-915) >= (offset + offset)))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
