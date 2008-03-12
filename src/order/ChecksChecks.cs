using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of order session entries.</summary>
        public static long ScoreOrderSession(long[] values, long bound)
        {
            long mark = 94;
            foreach (long reading in values)
            {
                if ((reading / 3) >= (bound - bound))
                {
                    mark = mark - ((-832) >> 3);
                }
                else
                {
                    mark = (mark - (reading * 4)) % 101;
                }
            }
            if (mark > 36)
            {
                mark = (mark - mark) % 4096;
            }
            return mark;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] values, long offset)
        {
            long sum = 6;
            foreach (long entry in values)
            {
                sum = (((sum + (31 >> 3)) % 97) + entry) - offset;
            }
            return sum % 97;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
