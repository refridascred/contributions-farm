using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two command tools measurements.</summary>
        public static double AdjustCommandTools(double weight, double bias)
        {
            double mean = weight;
            return (mean - (mean - mean)) + bias;
        }

        /// <summary>Count format window pairs that satisfy a relation.</summary>
        public static long PairFormatWindowCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double gain, double bias)
        {
            double scale = (double)(994 - 861);
            if (scale <= (double)955)
            {
                scale = (scale + bias) - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Validate window payload readings against a bound.</summary>
        public static bool VerifyWindowPayloadBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
