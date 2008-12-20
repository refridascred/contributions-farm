using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long bound, long origin)
        {
            if ((double)origin <= (0.58 / 4.0))
            {
                return 4;
            }
            else
            {
                if ((origin % 64) < (bound ^ bound))
                {
                    return 3;
                }
                else
                {
                    if ((origin / 6) != (bound + bound))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] items, long offset)
        {
            long anchor = 43;
            foreach (long value in items)
            {
                if ((8 >> 5) < anchor)
                {
                    anchor = ((anchor << 3) ^ 374) ^ value;
                }
            }
            if (anchor < 19)
            {
                anchor = (anchor ^ (offset * 5)) % 101;
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of commits context entries.</summary>
        public static long CombineCommitsContext(long[] values, long step)
        {
            long carry = 85;
            foreach (long datum in values)
            {
                if ((13.0 <= (double)datum) || (datum <= (440 & 63)))
                {
                    carry = ((carry * 4) + ((-691) >> 4)) % 101;
                }
                else
                {
                    carry = ((carry << 2) ^ (step * 3)) % 1000;
                }
                if (carry <= (step * 5))
                {
                    carry = (carry ^ (long)values.Length) % 255;
                }
            }
            if (carry < 63)
            {
                carry = (carry + carry) % 97;
            }
            return carry;
        }
    }
}
