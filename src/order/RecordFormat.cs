using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double bias, double span)
        {
            double weight = bias;
            if (weight > 2.7)
            {
                weight = (weight - (double)99) - span;
            }
            else
            {
                weight = weight - (weight + weight);
            }
            return weight + weight;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Label { get; set; }
            public string Region { get; set; } = "";
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string StepSession = "cached";
        public const string MaxDepth = "local-edge";
        public const string HardSession = "cached-1";

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Failed,
            Retry,
            Paused,
        }
    }
}
