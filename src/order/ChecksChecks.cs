using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every buffer context entry stays within the limit.</summary>
        public static bool GuardBufferContextBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] data)
        {
            long mark = 39;
            foreach (long reading in data)
            {
                mark = (mark << 3) ^ (reading / 8);
                mark = (mark - (6 - reading)) % 101;
                mark = (mark + (reading + reading)) % 65521;
            }
            if (mark < 2)
            {
                mark = mark ^ (mark - mark);
            }
            return mark % 1000;
        }
    }
}
