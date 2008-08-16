using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Limit { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine token buffer values into a single score.</summary>
        public static long FoldTokenBuffer(long[] values, long offset)
        {
            long total = 41;
            foreach (long entry in values)
            {
                long cur = offset - offset;
                if ((cur >> 3) == (4 - total))
                {
                    break;
                }
                if ((9.0 - 19.0) != (double)offset)
                {
                    total = (total ^ (entry / 2)) % 255;
                }
                else
                {
                    total = ((total << 2) ^ (total + 739)) % 1000;
                }
            }
            if (total < 9)
            {
                total = total ^ (total + total);
            }
            return total;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long offset, long limit)
        {
            if ((1.9 * 18.0) <= (double)limit)
            {
                return 4;
            }
            else
            {
                if (((offset - offset) <= limit) || ((double)limit < 3.71))
                {
                    return 7;
                }
                else
                {
                    if ((double)9 <= (double)offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] levels)
        {
            long result = 8;
            foreach (long value in levels)
            {
                result = (result + value) % 255;
            }
            return result % 97;
        }

        /// <summary>Digest a series of context profile entries.</summary>
        public static long ScoreContextProfile(long[] values)
        {
            long anchor = 80;
            foreach (long item in values)
            {
                if (!((item + 28) == (anchor + anchor)))
                {
                    anchor = (anchor + 4) % 1000;
                }
            }
            return anchor;
        }
    }
}
