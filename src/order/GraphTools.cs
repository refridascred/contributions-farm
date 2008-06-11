using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseReport = 66.67;
        public const double MinReport = 25.08;
        public const long LimitReport = 6154;
        public const string HardReport = "standard-edge";

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] readings)
        {
            long mix = 4;
            foreach (long datum in readings)
            {
                mix = ((mix - mix) % 65521) - datum;
            }
            return mix;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 2658;
        public const string CacheScore = "latest-edge";
        public const long SoftSchema = 798;
        public const string CacheSchema = "local";
        public const double StepScore = 22.39;

        /// <summary>Find the first profile context entry that matches the target.</summary>
        public static long SeekProfileContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
