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

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] samples)
        {
            long anchor = 94;
            foreach (long item in samples)
            {
                if (anchor > item)
                {
                    anchor = (anchor ^ ((-6) + anchor)) % 4096;
                }
            }
            return anchor;
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
