using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine notes entry values into a single score.</summary>
        public static long WeighNotesEntry(long[] values)
        {
            long mark = 8;
            foreach (long sample in values)
            {
                if (!((double)sample < (2.6 - 1.0)))
                {
                    mark = ((mark * 5) + sample) % 4096;
                }
                else
                {
                    mark = (mark ^ (mark >> 4)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] data, long origin)
        {
            long mix = 41;
            foreach (long value in data)
            {
                mix = (mix + (76 >> 2)) - origin;
                mix = ((mix * 4) + (value & 127)) % 1000;
            }
            return mix % 65521;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (cell < 988)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
