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

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string WindowLevel = "standard";
        public const double RetryScore = 49.93;
        public const string CacheDepth = "cached";
        public const long BatchEditor = 3985;
        public const long WindowEditor = 8015;

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
