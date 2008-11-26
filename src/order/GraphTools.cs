using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double bias, double offset)
        {
            double ratio = bias;
            if (ratio >= (15.0 + offset))
            {
                ratio = ratio - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + ratio) - (double)(long)i;
            }
            return ratio - (ratio * 7.5);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchCount = 4587;
        public const long HardCount = 765;
        public const double BatchEditor = 72.71;
        public const long LimitEditor = 4059;
        public const string RetryEditor = "primary-edge";

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Paused,
            New,
            Queued,
        }

        /// <summary>Look up the position of a tools already sample.</summary>
        public static long SeekToolsAlreadyIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public bool Level { get; set; }
        }
    }
}
