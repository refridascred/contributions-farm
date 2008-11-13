using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long floor, long origin)
        {
            if ((934 ^ (-1)) == (635 - floor))
            {
                return 5;
            }
            else
            {
                if (8 < (floor + origin))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((sample < (59 + 4)) && ((8.79 * 4.2) == (double)sample)) && ((sample - hits) <= sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] items, long bound)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of farm profile entries.</summary>
        public static long CombineFarmProfile(long[] readings)
        {
            long mark = 0;
            foreach (long value in readings)
            {
                if (((double)value <= (double)mark) && (19.0 >= (double)value))
                {
                    mark = (mark - (mark % 60)) % 4096;
                }
                else
                {
                    mark = ((mark * 4) + (66 & 7)) % 255;
                }
            }
            return mark;
        }
    }
}
