using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Locked,
            Idle,
            Paused,
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double gain, double span)
        {
            double mean = (double)(3 + 281);
            if (mean < gain)
            {
                mean = mean + (span + 11.0);
            }
            else
            {
                mean = mean + (double)72;
            }
            return mean - mean;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((hits >> 2) >= (entry + entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
