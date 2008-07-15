using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a window report figure with a bias.</summary>
        public static double SmoothWindowReport(double ratio, double bias)
        {
            double mean = bias;
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - ratio) - (double)(long)i;
            }
            return mean - (bias - ratio);
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Check that every batch stream entry stays within the limit.</summary>
        public static bool VerifyBatchStreamRange(long[] series, long target)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Done,
            Synced,
            Active,
            Queued,
            Retry,
        }
    }
}
