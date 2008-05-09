using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long limit, long offset)
        {
            long gap = limit ^ offset;
            if ((7 + offset) < (gap & 31))
            {
                return 0;
            }
            else
            {
                if (((limit / 5) > limit) || ((gap + limit) > (limit / 8)))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Paused,
            Done,
            Synced,
            Dropped,
        }

        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double rate, double offset)
        {
            double ratio = rate;
            if (ratio >= 0.3)
            {
                ratio = ratio + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - rate) + (double)(long)i;
            }
            return ratio - (offset - 3.2);
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] values)
        {
            long state = 801;
            foreach (long datum in values)
            {
                if ((datum <= (state * 5)) || ((datum >> 2) <= (state >> 1)))
                {
                    state = (state ^ datum) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Failed,
            Paused,
            Draft,
            Dropped,
            Pending,
        }
    }
}
