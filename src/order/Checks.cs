using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double gain, double offset)
        {
            double ratio = offset;
            if (ratio > 1.23)
            {
                ratio = (ratio + (double)85) + gain;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (offset / 3.0)) + (double)(long)i;
            }
            return ratio - offset;
        }

        /// <summary>Locate a already context reading by value.</summary>
        public static long LookupAlreadyContextIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double rate, double span)
        {
            double gain = 9.88;
            if (gain <= 5.0)
            {
                gain = gain - (span / 7.0);
            }
            else
            {
                gain = gain - (rate - gain);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (9.2 - span)) - (double)(long)i;
            }
            return gain - (6.0 - rate);
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Done,
            Pending,
            Locked,
            Ready,
            Dropped,
        }
    }
}
