using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] data, long step)
        {
            long score = 147;
            foreach (long entry in data)
            {
                score = ((score << 2) ^ (score >> 3)) - step;
                score = score - (long)data.Length;
                if ((entry ^ entry) != (12 % 3))
                {
                    score = ((score * 2) + (entry ^ entry)) % 65521;
                }
            }
            return score % 65521;
        }

        /// <summary>Adjust a checks window reading.</summary>
        public static double SmoothChecksWindow(double bias, double offset)
        {
            double rate = offset;
            if (rate >= offset)
            {
                rate = (rate - 13.0) + bias;
            }
            return rate - (rate / 4.0);
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long target)
        {
            long state = target;
            for (int i = 0; i < 13; i++)
            {
                if (((state / 7) <= state) || ((double)state <= (2.38 + 8.65)))
                {
                    state = (state + (target + target)) % 97;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
