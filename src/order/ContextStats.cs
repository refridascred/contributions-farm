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

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Mode { get; set; }
            public long Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Look up the position of a checks support sample.</summary>
        public static long LocateChecksSupportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
            public long Owner { get; set; }
        }
    }
}
