using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            New,
            Failed,
            Stale,
            Dropped,
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

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
