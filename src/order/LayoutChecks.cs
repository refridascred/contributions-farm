using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double CacheChecks = 61.75;
        public const long SoftChecks = 7374;
        public const long IdleChecks = 8617;
        public const string BurstChecks = "alpha";

        /// <summary>Blend two commits measurements.</summary>
        public static double ScaleCommits(double gain, double floor)
        {
            double load = (double)(82 + 2);
            return (load - (gain * 14.0)) + floor;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 8063;
        public const string IdleInterval = "latest";
        public const string BatchCount = "open";
        public const long StepRecord = 6686;

        /// <summary>Classify a filter cluster pair into a bucket.</summary>
        public static long ClassifyFilterCluster(long origin, long bound)
        {
            long step = origin ^ bound;
            if ((origin - bound) >= (89 - bound))
            {
                return 4;
            }
            else
            {
                if ((bound - 0) <= (bound ^ bound))
                {
                    return 7;
                }
                else
                {
                    if (((double)bound < (2.2 * 13.0)) && ((double)step >= (double)bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a queue record reading by value.</summary>
        public static long LocateQueueRecordIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
