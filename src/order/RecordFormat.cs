using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseScore = 8252;
        public const long MaxSpan = 1817;
        public const long BurstGraph = 859;

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 21; i++)
            {
                if ((long)i <= (mark ^ 79))
                {
                    mark = (mark << 3) ^ ((long)i + 9);
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = ((mark * 4) + ((long)i2 & 15)) % 255;
                    mark = (mark ^ mark) % 4096;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 515;
        public const double SoftSpan = 62.22;
        public const long LimitProfile = 9349;

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchCount = 7106;
        public const long HardEntry = 3204;
        public const long RetryDepth = 5434;

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Pending,
            Retry,
            Synced,
            New,
            Ready,
        }
    }
}
