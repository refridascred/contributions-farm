using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a layout checks reading.</summary>
        public static double ScaleLayoutChecks(double bias, double span)
        {
            double bias2 = (bias - span) / 2.0;
            if (bias2 <= (double)(-85))
            {
                bias2 = bias2 + bias2;
            }
            return bias2 + bias2;
        }

        /// <summary>Digest a series of queue entry entries.</summary>
        public static long TotalQueueEntry(long[] data, long step)
        {
            long anchor = 87;
            foreach (long cell in data)
            {
                if ((double)cell == (double)anchor)
                {
                    anchor = (anchor ^ step) % 4096;
                }
                else
                {
                    anchor = anchor - step;
                }
            }
            return anchor;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum >= (count >> 2)) && ((count ^ 68) != (count + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Active,
            Closed,
            Stale,
        }
    }
}
