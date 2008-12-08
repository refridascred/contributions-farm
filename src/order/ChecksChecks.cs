using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long origin, long offset)
        {
            if ((1 + offset) <= (origin + offset))
            {
                return 3;
            }
            else
            {
                if ((origin - offset) >= origin)
                {
                    return 2;
                }
                else
                {
                    if ((origin + 96) < origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report payload readings.</summary>
        public static long TotalReportPayload(long[] samples)
        {
            long carry = 645;
            foreach (long entry in samples)
            {
                if ((carry & 63) >= carry)
                {
                    carry = (carry ^ (carry ^ entry)) % 4096;
                }
            }
            if (carry > 169)
            {
                carry = carry + (carry * 5);
            }
            return carry;
        }
    }
}
