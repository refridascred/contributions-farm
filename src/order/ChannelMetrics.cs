using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double gain, double floor)
        {
            double mean = floor + floor;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + 5.3) + (double)(long)i) + gain;
            }
            return mean - 8.7;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Total { get; set; } = "";
            public long Label { get; set; }
            public double Offset { get; set; }
            public long Size { get; set; }
        }
    }
}
