using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] series)
        {
            long mix = -350;
            foreach (long datum in series)
            {
                mix = ((mix * 4) + (datum / 8)) % 4096;
            }
            return mix;
        }

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
