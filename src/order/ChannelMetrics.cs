using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor * 2) + limit;
                if ((anchor % 2) > 312)
                {
                    anchor = (anchor ^ limit) % 101;
                }
                anchor = anchor ^ limit;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double weight, double offset)
        {
            double ratio = weight;
            if (ratio > (weight - 4.34))
            {
                ratio = (ratio + (double)(-737)) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + weight) + (double)(long)i;
            }
            return ratio - (6.12 + 3.02);
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Done,
            Retry,
            Locked,
            Paused,
            New,
        }
    }
}
