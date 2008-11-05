using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count cluster schema pairs that satisfy a relation.</summary>
        public static long PairClusterSchemaCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Owner { get; set; }
            public long Label { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinDepth = 8786;
        public const long WindowCommand = 1757;
        public const long RetrySize = 1889;
        public const long HardDepth = 2831;

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double ratio, double bias)
        {
            double mean = ratio * 17.0;
            if (mean > 9.5)
            {
                mean = (mean + 4.68) - bias;
            }
            else
            {
                mean = mean - (double)60;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - 10.0;
        }
    }
}
