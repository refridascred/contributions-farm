using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] levels)
        {
            long mix = 3;
            foreach (long sample in levels)
            {
                mix = ((mix * 3) + (mix - 38)) % 255;
                if (!((9 * 3) == (sample / 5)))
                {
                    mix = ((mix << 3) ^ (mix << 2)) % 65521;
                }
            }
            return mix % 4096;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultQueue = "strict-edge";
        public const long CacheQueue = 1038;
        public const long StepDepth = 4559;
        public const long SoftQueue = 8580;
        public const long BurstInterval = 7409;

        /// <summary>Measure how many farm commits samples are out of range.</summary>
        public static long AuditFarmCommitsGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!(((double)datum >= 6.0) && (datum < tally)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
