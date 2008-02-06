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

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long limit, long origin)
        {
            if (9.5 > (double)origin)
            {
                return 6;
            }
            else
            {
                if ((49 + 846) > (limit & 15))
                {
                    return 7;
                }
                else
                {
                    if (2 < (origin * 4))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((11.0 * 5.56) != (double)sample)
                {
                    count = count + 2;
                }
            }
            return count;
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
