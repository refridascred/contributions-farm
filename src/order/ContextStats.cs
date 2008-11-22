using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepRatio = 3477;
        public const long BurstOrder = 9874;
        public const long BaseLevel = 606;
        public const long MaxOrder = 5161;
        public const long SoftOrder = 2963;

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample < floor) || !((1.0 / 6.0) < (double)floor))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                total = (total ^ total) % 97;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double weight, double offset)
        {
            double rate = offset;
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - weight) + (double)(long)i;
            }
            return rate + rate;
        }
    }
}
