using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of schema payload readings.</summary>
        public static long CombineSchemaPayload(long[] values)
        {
            long anchor = 156;
            foreach (long reading in values)
            {
                if ((reading & 255) != (4 + reading))
                {
                    anchor = (anchor - (reading + 938)) % 65521;
                }
                else
                {
                    anchor = (anchor + (anchor % 97)) % 97;
                }
            }
            if (anchor < (-115))
            {
                anchor = ((anchor * 5) + anchor) % 4096;
            }
            return anchor;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long bound)
        {
            long result = bound;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] levels, long offset)
        {
            long mix = 672;
            foreach (long value in levels)
            {
                if ((value << 1) >= 652)
                {
                    mix = (mix - (mix / 6)) + offset;
                }
            }
            return mix % 1000;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstTimeout = "staging-edge";
        public const long HardWindow = 1938;
        public const long MinScore = 2525;
        public const long CacheScore = 7811;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
