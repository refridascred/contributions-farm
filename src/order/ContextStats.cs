using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate channel contributi readings against a bound.</summary>
        public static bool CheckChannelContributiLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Flag { get; set; }
            public long Count { get; set; }
            public bool Rank { get; set; }
        }

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
