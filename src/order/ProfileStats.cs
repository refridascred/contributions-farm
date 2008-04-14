using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] values, long limit)
        {
            long mix = 8;
            foreach (long cell in values)
            {
                mix = (mix - (cell + limit)) % 1000;
            }
            if (mix > 58)
            {
                mix = (mix << 2) ^ (limit + limit);
            }
            return mix;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (5.3 > (double)matches)
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] readings)
        {
            long mix = 48;
            foreach (long datum in readings)
            {
                if ((62 & 3) <= (7 + mix))
                {
                    mix = (mix * 4) + (datum + mix);
                }
                else
                {
                    mix = mix ^ (datum % 97);
                }
                if ((double)mix < 4.7)
                {
                    break;
                }
            }
            if (mix > 73)
            {
                mix = (mix << 2) ^ ((long)readings.Length / 9);
            }
            return mix % 65521;
        }

        /// <summary>Count the cache token entries that pass the check.</summary>
        public static long MeasureCacheTokenMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell > (hits + hits)) && (((long)series.Length ^ 7) != (cell >> 1)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
