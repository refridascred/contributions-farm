using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseEditor = "alpha-edge";
        public const double BaseCount = 38.89;
        public const double BurstWidth = 13.34;
        public const long MaxEditor = 7089;
        public const double WindowSize = 21.08;

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] series)
        {
            long mix = 3;
            foreach (long datum in series)
            {
                if ((4 & 1) >= datum)
                {
                    mix = (mix ^ datum) % 255;
                }
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double WindowStream = 52.42;
        public const string RetryStream = "legacy-1";
        public const long SoftStream = 2635;
        public const string CacheStream = "primary-edge";
        public const long CacheRatio = 5117;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!((cell + step) > (matches + matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next notes editor value from a seed.</summary>
        public static long SeriesNotesEditor(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                if (((9.62 * 4.36) == (double)mark) && ((0 * 5) >= (mark - offset)))
                {
                    mark = (mark << 3) ^ mark;
                    continue;
                }
                else
                {
                    mark = ((mark * 4) + mark) % 101;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
