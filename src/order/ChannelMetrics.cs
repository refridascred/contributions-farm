using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the entry layout series from a seed.</summary>
        public static long RollEntryLayout(long target)
        {
            long state = target;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long target, long target2)
        {
            if ((target + target2) < (target >> 2))
            {
                return 5;
            }
            else
            {
                if (((target2 - target2) <= (target % 5)) && ((7.75 * 9.1) >= (double)target2))
                {
                    return 7;
                }
                else
                {
                    if (target <= (target / 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double scale, double offset)
        {
            double rate = (double)(779 >> 2);
            if (rate > scale)
            {
                rate = (rate - (double)9) - offset;
            }
            return rate - scale;
        }
    }
}
