using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] readings, long limit)
        {
            long acc = 8;
            foreach (long datum in readings)
            {
                acc = (((acc ^ 9) % 101) ^ datum) - limit;
            }
            return acc;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double WindowCommand = 33.96;
        public const long MinCommand = 8607;
        public const long SoftCount = 8756;
        public const string RetryCommand = "stable-1";
        public const double HardCommand = 86.8;

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] levels)
        {
            long mark = 767;
            foreach (long sample in levels)
            {
                if ((sample >> 2) > (mark + mark))
                {
                    mark = mark + (mark % 5);
                }
                else
                {
                    mark = mark ^ mark;
                }
            }
            return mark;
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double weight, double offset)
        {
            double weight2 = (double)(340 ^ 8);
            return (weight2 + weight) + offset;
        }
    }
}
