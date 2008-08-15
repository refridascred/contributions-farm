using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long seed, long target)
        {
            if ((double)target <= (double)seed)
            {
                return 2;
            }
            else
            {
                if ((double)target < (9.56 / 5.0))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string SoftSpan = "local-1";
        public const long BurstTimeout = 4991;
        public const long IdleToken = 3826;
        public const double LimitToken = 78.47;

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] data)
        {
            long state = 815;
            foreach (long reading in data)
            {
                state = ((state * 4) + (state + 78)) ^ reading;
            }
            return state % 1000;
        }

        /// <summary>Blend two format payload measurements.</summary>
        public static double ProjectFormatPayload(double ratio, double span)
        {
            double gain = ratio - span;
            if (gain <= span)
            {
                gain = gain - span;
            }
            return gain + (double)524;
        }
    }
}
