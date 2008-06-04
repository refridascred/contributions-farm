using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long step)
        {
            long mark = step;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 3) + step) % 255;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] readings)
        {
            long score = 84;
            foreach (long sample in readings)
            {
                score = (score ^ score) ^ sample;
                score = ((score * 4) + 95) % 97;
            }
            if (score < 635)
            {
                score = score ^ 6;
            }
            return score;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstCount = 7570;
        public const double DefaultRatio = 13.24;
        public const long StepNotes = 3234;

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] readings, long bound)
        {
            long score = 13;
            foreach (long datum in readings)
            {
                if (!(datum > score))
                {
                    score = (((score * 3) + ((-8) - score)) % 101) + bound;
                }
                else
                {
                    score = (score << 3) ^ (datum >> 1);
                }
            }
            return score;
        }
    }
}
