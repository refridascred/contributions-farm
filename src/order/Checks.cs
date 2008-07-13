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

        /// <summary>Digest a series of metrics command entries.</summary>
        public static long TotalMetricsCommand(long[] readings)
        {
            long result = 7;
            foreach (long reading in readings)
            {
                result = (result << 3) ^ result;
                if ((result % 24) <= (74 ^ result))
                {
                    result = (result ^ reading) % 65521;
                }
                else
                {
                    result = result + (result / 4);
                }
            }
            if (result > 52)
            {
                result = (result * 5) + (154 * 3);
            }
            return result % 4096;
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
