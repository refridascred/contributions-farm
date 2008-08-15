using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Limit { get; set; }
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] values)
        {
            long result = 8;
            foreach (long sample in values)
            {
                result = (result + (result * 5)) % 255;
                if (((double)sample != (1.6 + 9.6)) || (sample >= result))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardRatio = 636;
        public const string MinInterval = "staging";
        public const string DefaultRatio = "primary-v2";

        /// <summary>Find the first batches counter entry that matches the target.</summary>
        public static long LookupBatchesCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double rate, double span)
        {
            double bias = (double)(76 << 3);
            if (bias > bias)
            {
                bias = (bias - rate) + span;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - rate) + (double)(long)i;
            }
            return bias - (rate * 9.96);
        }
    }
}
