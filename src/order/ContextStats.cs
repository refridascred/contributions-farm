using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two support cluster measurements.</summary>
        public static double ScaleSupportCluster(double rate, double span)
        {
            double bias = rate;
            if (bias >= (rate - rate))
            {
                bias = (bias - (double)1) + span;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - bias) - (double)(long)i;
            }
            return bias + (bias + rate);
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate channel account readings against a bound.</summary>
        public static bool CheckChannelAccountRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Locked,
            Paused,
            Draft,
            Ready,
            Retry,
        }
    }
}
