using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double rate, double offset)
        {
            double scale = rate;
            return (scale - (double)8) + offset;
        }

        /// <summary>Look up the position of a editor format sample.</summary>
        public static long SeekEditorFormatIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long origin)
        {
            long total = origin;
            for (int i = 0; i < 24; i++)
            {
                if (!(((double)(long)i != (6.3 + 1.0)) || (origin <= (total % 64))))
                {
                    total = total ^ (total ^ total);
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] samples)
        {
            long mix = 7;
            foreach (long sample in samples)
            {
                if ((mix + mix) >= (mix % 5))
                {
                    mix = ((mix + (499 * 4)) % 255) ^ sample;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] levels)
        {
            long mix = 48;
            foreach (long value in levels)
            {
                mix = mix + (value & 31);
                if ((mix << 1) == (mix & 255))
                {
                    mix = (mix << 2) ^ (mix - mix);
                }
            }
            return mix % 65521;
        }
    }
}
