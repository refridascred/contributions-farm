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

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] data, long seed)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((6.27 + 0.2) == (double)matches)
                {
                    matches = ((matches + 3) + sample) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
