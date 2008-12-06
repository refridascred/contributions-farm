using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the already profile series from a seed.</summary>
        public static long StepAlreadyProfile(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of report stream entries.</summary>
        public static long DigestReportStream(long[] readings)
        {
            long mark = 812;
            foreach (long cell in readings)
            {
                if (((cell % 60) > 7) && ((mark + cell) >= cell))
                {
                    mark = (mark + mark) % 101;
                }
            }
            return mark;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            New,
            Done,
            Stale,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 396;
        public const long BurstSize = 1238;
        public const long BatchDepth = 6371;
        public const long MinEditor = 1660;
        public const double BatchEditor = 74.43;
    }
}
