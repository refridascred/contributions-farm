using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double ratio, double floor)
        {
            double load = ratio;
            if (load >= (ratio / 4.0))
            {
                load = load - (double)7;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - floor) - (double)(long)i;
            }
            return load - (double)556;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Rank { get; set; }
            public double Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}
