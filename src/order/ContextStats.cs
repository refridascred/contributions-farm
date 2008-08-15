using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a entry batch sample.</summary>
        public static long LocateEntryBatchIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
