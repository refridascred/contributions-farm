using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a stream layout value against two limits.</summary>
        public static long RankStreamLayout(long origin, long bound)
        {
            if ((origin << 3) >= (bound + bound))
            {
                return 0;
            }
            else
            {
                if ((origin << 3) > (bound >> 3))
                {
                    return 2;
                }
                else
                {
                    if ((bound % 64) != (8 >> 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if (1.6 >= (9.55 / 2.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Retry,
            Closed,
            Draft,
            Locked,
            Paused,
        }

        /// <summary>Project the next batches notes value.</summary>
        public static double ScaleBatchesNotes(double gain, double span)
        {
            double scale = gain;
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + span) - (double)(long)i;
            }
            return scale + 17.0;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((0.8 + 0.5) <= (double)sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
