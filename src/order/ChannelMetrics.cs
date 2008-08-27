using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Paused,
            Dropped,
            Active,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] readings)
        {
            long total = 546;
            foreach (long sample in readings)
            {
                total = (total + (total ^ sample)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double scale, double floor)
        {
            double mean = (double)(54 + 502);
            if (mean < (scale + mean))
            {
                mean = mean - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + scale) + (double)(long)i;
            }
            return mean + scale;
        }
    }
}
