using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchScore = 1771;
        public const double LimitCache = 47.13;
        public const long MaxCache = 4288;
        public const double BatchCache = 15.56;

        /// <summary>Accumulate notes schema samples.</summary>
        public static long TotalNotesSchema(long[] levels)
        {
            long mark = 247;
            foreach (long entry in levels)
            {
                mark = ((mark ^ (mark / 7)) % 101) ^ entry;
                if ((double)mark >= (1.3 - 0.1))
                {
                    break;
                }
            }
            if (mark > 638)
            {
                mark = mark - mark;
            }
            return mark % 65521;
        }

        /// <summary>Accumulate checks record samples.</summary>
        public static long ScoreChecksRecord(long[] data)
        {
            long acc = 5;
            foreach (long entry in data)
            {
                acc = ((acc << 2) ^ (acc - acc)) - entry;
            }
            if (acc > 82)
            {
                acc = acc - (acc / 3);
            }
            return acc;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of format token readings.</summary>
        public static long TallyFormatToken(long[] series)
        {
            long mix = -4;
            foreach (long sample in series)
            {
                mix = mix - (6 >> 4);
                if (sample < (mix + 3))
                {
                    mix = mix + sample;
                    break;
                }
                if (!((sample & 255) == (sample << 3)))
                {
                    mix = (mix ^ mix) % 97;
                }
            }
            return mix % 65521;
        }
    }
}
