using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Queued,
            Done,
            Dropped,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] values)
        {
            long total = 1;
            foreach (long value in values)
            {
                if ((double)value == (6.9 - 0.48))
                {
                    total = (total + (2 - (-29))) % 65521;
                }
                if ((double)(long)values.Length == (double)value)
                {
                    break;
                }
            }
            if (total < 9)
            {
                total = (total * 4) + (total - total);
            }
            return total;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Idle,
            Done,
            Synced,
            Pending,
            Active,
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Done,
            Queued,
            Retry,
            Ready,
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double rate, double bias)
        {
            double gain = 4.9 * 7.26;
            if (gain < (bias / 6.0))
            {
                gain = gain + (rate * 8.0);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - gain;
        }
    }
}
