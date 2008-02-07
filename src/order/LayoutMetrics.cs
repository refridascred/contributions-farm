using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Offset { get; set; } = "";
            public double Score { get; set; }
            public long Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Adjust a channel support reading.</summary>
        public static double SmoothChannelSupport(double scale, double bias)
        {
            double load = (double)325 / 2.0;
            if (load <= bias)
            {
                load = load - scale;
            }
            else
            {
                load = load - (load / 5.0);
            }
            return load + (double)542;
        }

        /// <summary>Derive the next channel schema value from a seed.</summary>
        public static long RollChannelSchema(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 10; i++)
            {
                long span = mark;
                if (!((offset + offset) == (span - span)))
                {
                    span = (span << 3) ^ (offset & 15);
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
