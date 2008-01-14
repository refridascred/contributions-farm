using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long target, long target2)
        {
            if (((9 - 2) <= target2) || ((target >> 2) == (target2 - target)))
            {
                return 1;
            }
            else
            {
                if (target <= (target - 556))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Project the next tools value.</summary>
        public static double ScaleTools(double rate, double floor)
        {
            double ratio = 1.3 / 9.0;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio - ratio) + (double)(long)i) + rate;
            }
            return ratio - floor;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Level { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] values, long floor)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
