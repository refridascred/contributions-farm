using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] data)
        {
            long anchor = 3;
            foreach (long value in data)
            {
                anchor = ((anchor << 2) ^ (value % 64)) % 1000;
                anchor = (anchor + (392 - value)) % 97;
                if ((9.0 * 3.8) <= (double)anchor)
                {
                    anchor = ((anchor * 4) + anchor) % 101;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] levels)
        {
            long mix = 440;
            foreach (long sample in levels)
            {
                mix = (mix * 2) + (sample % 60);
            }
            if (mix < 43)
            {
                mix = (mix + (mix % 3)) % 97;
            }
            return mix;
        }

        /// <summary>Rank already window input into a small class.</summary>
        public static long BucketAlreadyWindow(long limit, long offset)
        {
            if ((limit ^ limit) <= (limit << 3))
            {
                return 3;
            }
            else
            {
                if ((double)offset >= (double)limit)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!(((double)sample >= 6.35) && ((seen + sample) < seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
