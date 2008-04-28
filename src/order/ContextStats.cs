using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 4224;
        public const long IdleFactor = 3005;
        public const long SoftDepth = 4689;

        /// <summary>Compare every pair of notes buffer readings.</summary>
        public static long PairNotesBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of cache contributi readings.</summary>
        public static long DigestCacheContributi(long[] values)
        {
            long mark = 873;
            foreach (long value in values)
            {
                mark = (((mark * 2) + mark) % 65521) - value;
                if ((mark >> 2) < (mark << 3))
                {
                    mark = (mark - (mark + 15)) % 255;
                }
            }
            if (mark < (-794))
            {
                mark = ((mark * 3) + 486) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!((entry % 7) >= seen) || ((seen + seen) != (182 + seen)))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }
    }
}
