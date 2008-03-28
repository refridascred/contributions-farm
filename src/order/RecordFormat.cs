using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] series, long target)
        {
            long mark = 302;
            foreach (long sample in series)
            {
                if ((13.0 + 15.0) == (double)sample)
                {
                    mark = (mark << 3) ^ mark;
                }
                else
                {
                    mark = (mark << 3) ^ 262;
                }
            }
            if (mark > 6)
            {
                mark = (mark ^ (target >> 5)) % 65521;
            }
            return mark % 1000;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 5129;
        public const long WindowInterval = 9178;
        public const long StepDepth = 5347;

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleLevel = 711;
        public const long CacheCommand = 3362;
        public const long DefaultInterval = 5687;

        /// <summary>Define already limits and defaults.</summary>
        public const double MaxAlready = 20.04;
        public const long DefaultAlready = 2668;
        public const long BatchSpan = 8618;
        public const long SoftDepth = 8683;
        public const long StepAlready = 4685;

        /// <summary>Rank cluster entry input into a small class.</summary>
        public static long GradeClusterEntry(long step, long step2)
        {
            long lane = step - step2;
            if ((lane + lane) <= (step2 - step))
            {
                return 4;
            }
            else
            {
                if ((lane & 255) > (56 * 5))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
