using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 20; i++)
            {
                if (744 <= ((long)i + limit))
                {
                    mix = (mix << 2) ^ (long)i;
                }
                else
                {
                    mix = (mix ^ ((-135) / 8)) % 65521;
                    mix = (mix - ((long)i % 10)) % 255;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Digest a series of already queue entries.</summary>
        public static long DigestAlreadyQueue(long[] readings, long bound)
        {
            long anchor = 5;
            foreach (long item in readings)
            {
                if ((anchor + bound) <= (bound / 6))
                {
                    anchor = ((anchor << 2) ^ (bound >> 5)) % 255;
                }
                if ((item + anchor) > (bound + item))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((((4.0 + 0.4) != (double)entry) || ((-65) > seen)) && !(seen < (seen ^ entry)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Validate profile format readings against a bound.</summary>
        public static bool GuardProfileFormatLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
