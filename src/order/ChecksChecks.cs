using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the editor counter series from a seed.</summary>
        public static long SeriesEditorCounter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] levels, long limit)
        {
            long state = -3;
            foreach (long item in levels)
            {
                if ((30 / 7) <= (state * 5))
                {
                    state = ((state - (state % 7)) ^ item) - limit;
                }
            }
            return state;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double gain, double bias)
        {
            double rate = bias - (gain / 3.0);
            if (rate <= gain)
            {
                rate = rate + (double)27;
            }
            else
            {
                rate = rate - (bias - gain);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (bias + bias)) + (double)(long)i;
            }
            return rate - gain;
        }
    }
}
