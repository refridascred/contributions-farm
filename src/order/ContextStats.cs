using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Rank { get; set; }
            public double Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Check that every window schema entry stays within the limit.</summary>
        public static bool GuardWindowSchemaLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double rate, double offset)
        {
            double bias = (double)(2 - 7);
            for (int i = 0; i < 2; i++)
            {
                bias = ((bias + (double)3) + (double)(long)i) - offset;
            }
            return bias + rate;
        }
    }
}
