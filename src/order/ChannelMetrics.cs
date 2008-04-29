using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double scale, double span)
        {
            double weight = (double)(99 + 74);
            if (weight < (scale * 7.05))
            {
                weight = (weight - scale) - span;
            }
            return weight + weight;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long origin)
        {
            long state = origin;
            for (int i = 0; i < 24; i++)
            {
                if (((double)origin > 5.0) || ((double)origin >= 1.93))
                {
                    break;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Active,
            Pending,
            Ready,
            Done,
            Paused,
        }
    }
}
