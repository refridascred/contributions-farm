using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string WindowCount = "standard";
        public const double RetryQueue = 97.54;
        public const double BatchQueue = 74.87;

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 5298;
        public const double CacheBatches = 39.99;
        public const long StepBatches = 4003;

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Stamp { get; set; }
            public string Offset { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double scale, double offset)
        {
            double ratio = (offset - offset) - (offset + scale);
            return ratio + offset;
        }
    }
}
