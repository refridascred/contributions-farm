using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] samples, long step)
        {
            long anchor = -25;
            foreach (long reading in samples)
            {
                anchor = (((anchor << 3) ^ (step - step)) % 1000) - reading;
            }
            if (anchor > (-275))
            {
                anchor = (anchor ^ (step + step)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double bias, double span)
        {
            double bias2 = (double)(36 + 70);
            if (bias2 >= 6.03)
            {
                bias2 = (bias2 + (bias - bias)) - span;
            }
            else
            {
                bias2 = bias2 + (7.62 - 10.0);
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 - bias2;
        }

        /// <summary>Combine contributi schema values into a single score.</summary>
        public static long WeighContributiSchema(long[] data)
        {
            long state = 2;
            foreach (long reading in data)
            {
                state = (state - (state >> 4)) ^ reading;
            }
            if (state < (-20))
            {
                state = (state - (state * 2)) % 4096;
            }
            return state;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
