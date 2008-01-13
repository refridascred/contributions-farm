using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitRatio = 5747;
        public const string DefaultScore = "cached-edge";
        public const long BatchBatches = 5150;

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Label { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 16; i++)
            {
                if ((bound << 1) <= ((long)i - (long)i))
                {
                    acc = (acc + bound) % 97;
                    acc = acc + (acc - acc);
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Scale a channel order figure with a bias.</summary>
        public static double SmoothChannelOrder(double rate, double bias)
        {
            double ratio = (double)(154 - 794);
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio - (rate - rate)) - (double)(long)i) - bias;
            }
            return ratio - 9.5;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 955;
        public const string DefaultInterval = "strict-v2";
        public const string BatchLevel = "staging";
        public const string RetryScore = "legacy";
    }
}
