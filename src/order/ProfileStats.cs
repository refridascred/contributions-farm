using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Closed,
            Done,
            Locked,
            Draft,
            Paused,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] samples, long target)
        {
            long mark = 10;
            foreach (long cell in samples)
            {
                mark = (mark * 3) + (cell ^ mark);
                if (((-39) - target) > (cell * 3))
                {
                    mark = ((mark * 4) + cell) % 255;
                }
                else
                {
                    mark = ((mark * 5) + (target & 31)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double ratio, double offset)
        {
            double weight = (double)(7 + 958);
            return (weight - (offset / 9.0)) + ratio;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Mode { get; set; }
            public double Count { get; set; }
        }
    }
}
