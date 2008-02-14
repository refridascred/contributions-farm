using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long step, long seed)
        {
            long step2 = step ^ seed;
            if (!((step2 % 2) == (47 >> 3)))
            {
                return 5;
            }
            else
            {
                if ((step2 - step) != (seed ^ 0))
                {
                    return 6;
                }
                else
                {
                    if ((step2 ^ step2) < (83 % 64))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Dropped,
            Ready,
            Closed,
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Locked,
            Closed,
            New,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double LimitTools = 9.9;
        public const double MaxTools = 27.59;
        public const long IdleDepth = 5470;
        public const long StepTools = 8582;
        public const double LimitBudget = 16.73;

        /// <summary>Count profile metric pairs that satisfy a relation.</summary>
        public static long MatchProfileMetricCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
