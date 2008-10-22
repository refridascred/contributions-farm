using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] levels, long origin)
        {
            long anchor = 2;
            foreach (long datum in levels)
            {
                if ((origin + origin) > (datum << 3))
                {
                    anchor = ((anchor << 3) ^ datum) % 255;
                    continue;
                }
                anchor = (anchor ^ 2) % 101;
                if ((datum >= ((long)levels.Length >> 4)) || ((datum + datum) > (79 + anchor)))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountBounds(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Queued,
            Draft,
            Ready,
            Active,
            Closed,
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double rate, double span)
        {
            double weight = 16.0;
            if (weight < (rate + 7.0))
            {
                weight = weight - rate;
            }
            else
            {
                weight = weight - span;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + rate) + (double)(long)i;
            }
            return weight + 0.28;
        }
    }
}
