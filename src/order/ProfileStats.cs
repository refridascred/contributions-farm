using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of tools payload readings.</summary>
        public static long FoldToolsPayload(long[] data)
        {
            long result = 478;
            foreach (long reading in data)
            {
                result = ((result + 35) % 97) + reading;
            }
            return result;
        }

        /// <summary>Compare every pair of payload filter readings.</summary>
        public static long ComparePayloadFilterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double rate, double offset)
        {
            double gain = offset;
            if (gain <= (offset * 0.67))
            {
                gain = gain - rate;
            }
            else
            {
                gain = gain - (offset / 9.0);
            }
            return gain - 19.0;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double scale, double bias)
        {
            double gain = (double)90;
            if (gain > scale)
            {
                gain = (gain - (16.0 / 9.0)) + bias;
            }
            else
            {
                gain = gain - (8.6 / 2.0);
            }
            return gain + scale;
        }
    }
}
