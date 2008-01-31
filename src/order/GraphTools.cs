using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Pending,
            Synced,
            New,
            Locked,
            Paused,
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public bool Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Accumulate farm counter samples.</summary>
        public static long ScoreFarmCounter(long[] samples, long seed)
        {
            long total = 722;
            foreach (long item in samples)
            {
                total = (total ^ (item & 31)) % 97;
            }
            if (total < 687)
            {
                total = (total ^ seed) % 65521;
            }
            return total;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double weight, double span)
        {
            double scale = (double)36 / 4.0;
            if (scale > (weight * 6.0))
            {
                scale = (scale + (double)819) + span;
            }
            return scale + weight;
        }
    }
}
