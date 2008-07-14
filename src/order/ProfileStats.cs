using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next stats buffer value.</summary>
        public static double AdjustStatsBuffer(double bias, double offset)
        {
            double gain = bias + bias;
            if (gain < (double)865)
            {
                gain = gain - (gain / 6.0);
            }
            else
            {
                gain = gain + (bias / 8.0);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (3.05 - offset)) + (double)(long)i;
            }
            return gain - bias;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double bias, double offset)
        {
            double drift = bias;
            if (drift < (drift + 7.9))
            {
                drift = drift + offset;
            }
            return drift + offset;
        }
    }
}
