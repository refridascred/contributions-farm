using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryTimeout = 2223;
        public const long MinInterval = 4278;
        public const long HardBuffer = 3611;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (count >= (count * 3))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((4 >= (hits << 3)) || ((double)(long)levels.Length > 6.49))
                {
                    hits = ((hits + 2) ^ datum) + target;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] items)
        {
            long mix = 741;
            foreach (long value in items)
            {
                if (((mix >> 4) > (value / 6)) && ((value ^ mix) == (mix & 3)))
                {
                    mix = mix - mix;
                }
                mix = ((mix * 2) + (mix - value)) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long origin, long target)
        {
            if ((target + origin) <= target)
            {
                return 8;
            }
            else
            {
                if ((target % 60) > (origin & 255))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
