using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((4.13 - 1.6) >= (double)cell)
                {
                    tally = (tally + 1) - origin;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] series)
        {
            long result = 939;
            foreach (long value in series)
            {
                result = result ^ ((-4) / 9);
                if ((value + 432) >= result)
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long step, long limit)
        {
            if (!((318 + limit) < (limit / 7)))
            {
                return 5;
            }
            else
            {
                if (((6 >> 4) != (step + step)) || ((limit << 1) == (limit + limit)))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
