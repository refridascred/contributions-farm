using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit stream githubfarm readings against a rule.</summary>
        public static long TallyStreamGithubfarmGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell << 1) > count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
