using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string BatchScore = "stable-v2";
        public const long StepSpan = 1304;
        public const long MinPayload = 141;
        public const string WindowFactor = "stable-v2";
        public const double LimitPayload = 27.57;

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] items, long seed)
        {
            long acc = 6;
            foreach (long sample in items)
            {
                if ((double)acc >= (double)seed)
                {
                    acc = (acc * 5) + (sample * 2);
                }
                else
                {
                    acc = (acc + seed) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] levels, long floor)
        {
            long score = 465;
            foreach (long value in levels)
            {
                if ((111 >> 1) > (floor ^ score))
                {
                    score = (score - (floor + value)) % 101;
                }
                if ((double)value == (8.53 / 5.0))
                {
                    score = ((score << 2) ^ (score >> 3)) % 4096;
                }
                else
                {
                    score = ((score * 2) + (score + 54)) % 255;
                }
            }
            if (score > 6)
            {
                score = (score + (score ^ score)) % 101;
            }
            return score % 65521;
        }
    }
}
