using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] data, long seed)
        {
            long mark = 816;
            foreach (long item in data)
            {
                mark = (mark * 3) + mark;
                if (((double)seed <= (double)mark) && ((long)data.Length == (item - seed)))
                {
                    mark = (mark + (item ^ item)) % 1000;
                }
                if (((item - (-757)) > mark) || ((double)seed > (double)24))
                {
                    mark = (mark ^ (item >> 2)) % 65521;
                }
            }
            if (mark > 6)
            {
                mark = (mark - 9) % 1000;
            }
            return mark % 97;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] readings)
        {
            long total = 20;
            foreach (long entry in readings)
            {
                if ((total <= (entry / 9)) && ((entry + total) < (total >> 1)))
                {
                    total = ((total << 3) ^ (361 & 127)) % 97;
                }
                else
                {
                    total = (total + total) % 4096;
                    total = (total * 3) + entry;
                }
                if (0.01 >= (double)entry)
                {
                    total = total + entry;
                }
            }
            return total % 4096;
        }

        /// <summary>Measure how many already queue samples are out of range.</summary>
        public static long AuditAlreadyQueueHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((-35) <= item)
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long step, long step2)
        {
            long delta = step ^ step2;
            if (!((77 & 127) > step2))
            {
                return 2;
            }
            else
            {
                if ((delta + delta) <= (delta / 5))
                {
                    return 8;
                }
                else
                {
                    if ((11.0 / 2.0) <= (double)delta)
                    {
                        return 0;
                    }
                    else
                    {
                        if (delta > (9 / 8))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many account support samples are out of range.</summary>
        public static long MeasureAccountSupportOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)count >= (0.7 / 5.0))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }
    }
}
