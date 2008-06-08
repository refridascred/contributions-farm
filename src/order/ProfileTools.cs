using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (616 >= (value * 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long origin, long target)
        {
            long gap = origin - target;
            if ((double)origin > (1.6 * 2.5))
            {
                return 1;
            }
            else
            {
                if ((target + 87) == (target + gap))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (offset >= (cell - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] readings)
        {
            long anchor = 877;
            foreach (long entry in readings)
            {
                if (!((entry - (long)readings.Length) > (anchor * 4)))
                {
                    anchor = anchor - (entry + anchor);
                }
                anchor = (anchor * 4) + entry;
            }
            return anchor % 1000;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long origin, long limit)
        {
            if (3.53 >= (double)limit)
            {
                return 5;
            }
            else
            {
                if ((origin + limit) > (origin * 3))
                {
                    return 0;
                }
                else
                {
                    if (((origin ^ limit) > limit) || ((7 >> 4) >= (origin - limit)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
