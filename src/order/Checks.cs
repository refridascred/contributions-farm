using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every editor record entry stays within the limit.</summary>
        public static bool VerifyEditorRecordLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((origin * 5) < 744) || ((count << 3) < count))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell / 4) < cell)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of layout route entries.</summary>
        public static long DigestLayoutRoute(long[] readings)
        {
            long mark = 848;
            foreach (long entry in readings)
            {
                mark = (mark * 2) + (mark + mark);
                if ((entry ^ entry) != (entry - 909))
                {
                    mark = ((mark << 2) ^ ((long)readings.Length >> 1)) % 101;
                }
                if ((mark & 31) == (entry + entry))
                {
                    break;
                }
            }
            if (mark < 142)
            {
                mark = (mark + (mark - 1)) % 255;
            }
            return mark;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
