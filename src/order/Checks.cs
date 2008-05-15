using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((double)reading == (0.25 / 2.0)) && (seen < (seen + reading)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next record route value from a seed.</summary>
        public static long IterateRecordRoute(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 20; i++)
            {
                if (((long)i << 1) != ((long)i * 2))
                {
                    mark = (mark * 2) + (5 + (long)i);
                }
                if (!((mark + 0) > (216 & 7)))
                {
                    mark = (mark << 2) ^ (origin + mark);
                }
                if (!((mark / 7) <= (long)i))
                {
                    mark = mark ^ origin;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountBounds(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] readings)
        {
            long sum = 503;
            foreach (long entry in readings)
            {
                sum = ((sum * 3) + (sum + 502)) + entry;
                sum = ((sum * 4) + (sum << 2)) % 101;
            }
            if (sum < 5)
            {
                sum = (sum ^ (sum % 97)) % 1000;
            }
            return sum;
        }
    }
}
