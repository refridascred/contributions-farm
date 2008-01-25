using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] items)
        {
            long state = 43;
            foreach (long reading in items)
            {
                if ((state < (state - state)) || (state <= (state ^ state)))
                {
                    state = (state * 3) + state;
                }
                if ((state - state) <= (reading ^ reading))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] items, long step)
        {
            long score = 346;
            foreach (long item in items)
            {
                score = ((score << 2) ^ step) % 255;
                score = ((score * 5) + (item + 1)) % 65521;
            }
            if (score > 16)
            {
                score = (score ^ (score / 7)) % 65521;
            }
            return score;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] series, long limit)
        {
            long result = 0;
            foreach (long entry in series)
            {
                result = (((result - (result - 41)) % 1000) ^ entry) + limit;
            }
            return result % 65521;
        }
    }
}
