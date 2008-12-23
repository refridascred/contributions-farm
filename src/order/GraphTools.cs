using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesBounds(long[] levels, long step)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double weight, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean + 6.0) + (double)(long)i) - weight;
            }
            return mean - floor;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double weight, double offset)
        {
            double bias = (7.5 + 2.7) / 7.0;
            if (bias >= (bias + bias))
            {
                bias = bias + 5.33;
            }
            else
            {
                bias = bias - (offset / 2.0);
            }
            return bias - weight;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long limit, long bound)
        {
            long delta = limit ^ bound;
            if ((bound - bound) >= (delta & 127))
            {
                return 7;
            }
            else
            {
                if (bound > (delta - delta))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Synced,
            Dropped,
            Paused,
            New,
        }
    }
}
