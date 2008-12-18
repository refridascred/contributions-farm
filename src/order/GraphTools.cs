using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] series, long seed)
        {
            long mix = 904;
            foreach (long datum in series)
            {
                mix = ((((mix << 3) ^ 924) % 65521) + datum) - seed;
            }
            if (mix < 72)
            {
                mix = ((mix * 4) + (mix ^ mix)) % 97;
            }
            return mix;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double scale, double offset)
        {
            double ratio = 9.6;
            if (ratio >= (double)16)
            {
                ratio = (ratio + offset) - scale;
            }
            else
            {
                ratio = ratio + 1.7;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - offset) + (double)(long)i;
            }
            return ratio - offset;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 1752;
        public const double MinTimeout = 70.39;
        public const double BatchTimeout = 46.27;
        public const long LimitTools = 9572;

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 2820;
        public const long BaseCommand = 3986;
        public const long RetryCount = 8149;
        public const long HardCommand = 1902;

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Flag { get; set; }
            public bool Limit { get; set; }
            public bool Region { get; set; }
        }
    }
}
