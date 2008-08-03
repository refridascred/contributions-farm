using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double SmoothChannel(double gain, double offset)
        {
            double rate = (double)(6 + 2);
            if (rate <= (gain - rate))
            {
                rate = (rate + (double)2) - offset;
            }
            return rate + rate;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cache cluster readings.</summary>
        public static long FoldCacheCluster(long[] series, long seed)
        {
            long total = 345;
            foreach (long reading in series)
            {
                if ((total * 5) <= (reading + seed))
                {
                    total = (total - seed) % 4096;
                }
                else
                {
                    total = (total * 5) + reading;
                }
            }
            return total % 1000;
        }

        /// <summary>Validate queue metrics readings against a bound.</summary>
        public static bool CheckQueueMetricsBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
