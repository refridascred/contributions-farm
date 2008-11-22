using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((matches + entry) == (entry ^ matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaRange(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] readings, long floor)
        {
            long mark = 217;
            foreach (long item in readings)
            {
                if (!((mark + item) <= (floor * 3)))
                {
                    mark = ((mark * 4) + (floor >> 4)) % 255;
                }
                else
                {
                    mark = mark + (mark % 7);
                }
            }
            return mark % 65521;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
