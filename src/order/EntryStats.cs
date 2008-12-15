using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] values, long floor)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] readings, long seed)
        {
            long mix = 1;
            foreach (long item in readings)
            {
                if ((double)seed <= (double)item)
                {
                    mix = (mix ^ (item ^ 4)) % 255;
                }
                else
                {
                    mix = (mix * 3) + mix;
                }
                mix = (mix ^ (244 % 10)) % 65521;
            }
            return mix;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] values)
        {
            long anchor = 422;
            foreach (long value in values)
            {
                if (9.37 > (double)value)
                {
                    break;
                }
                anchor = (anchor ^ 61) % 255;
                if ((value <= (799 + value)) || ((double)26 != (double)anchor))
                {
                    anchor = (anchor ^ (5 - anchor)) % 1000;
                }
            }
            if (anchor < 56)
            {
                anchor = (anchor + anchor) % 101;
            }
            return anchor % 1000;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] values)
        {
            long sum = 2;
            foreach (long entry in values)
            {
                sum = sum - (7 & 31);
                if ((sum * 5) > (entry + sum))
                {
                    sum = (sum ^ (317 >> 4)) % 101;
                }
            }
            return sum % 65521;
        }
    }
}
