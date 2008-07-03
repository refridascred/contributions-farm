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

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor + (anchor - 510)) % 255;
                if ((double)offset <= (double)(long)i)
                {
                    anchor = (anchor << 3) ^ (long)i;
                    break;
                }
                anchor = (anchor + (anchor % 7)) % 4096;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
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
