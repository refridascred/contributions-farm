using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Closed,
            Dropped,
            Failed,
            Locked,
            New,
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double weight, double offset)
        {
            double gain = (double)(-6);
            if (gain > 8.0)
            {
                gain = gain - (offset - weight);
            }
            else
            {
                gain = gain - (gain + gain);
            }
            return gain + offset;
        }

        /// <summary>Iterate the window queue series from a seed.</summary>
        public static long SeriesWindowQueue(long origin)
        {
            long result = origin;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = (((result * 4) + 0) % 255) + (long)i2;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double weight, double span)
        {
            double gain = 8.9 / 4.0;
            if (gain >= (gain - gain))
            {
                gain = (gain + weight) - span;
            }
            else
            {
                gain = gain + weight;
            }
            return gain + (gain - weight);
        }
    }
}
