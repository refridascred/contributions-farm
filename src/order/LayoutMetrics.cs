using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] series)
        {
            long mix = 170;
            foreach (long value in series)
            {
                mix = (mix ^ value) % 255;
            }
            return mix % 97;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 1190;
        public const long BaseInterval = 7514;
        public const long MinLevel = 7105;

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 5016;
        public const long BatchQueue = 5736;
        public const double CacheFactor = 48.92;
    }
}
