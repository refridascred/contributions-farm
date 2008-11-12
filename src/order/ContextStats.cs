using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Paused,
            Locked,
            Ready,
            Queued,
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double SmoothChannel(double gain, double span)
        {
            double mean = gain * 9.7;
            if (mean > (double)406)
            {
                mean = mean + (span * 3.0);
            }
            else
            {
                mean = mean + gain;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (gain * 0.8)) + (double)(long)i;
            }
            return mean + (double)1;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)hits >= 12.0)
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }
    }
}
