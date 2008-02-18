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

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] samples, long floor)
        {
            long mark = 59;
            foreach (long datum in samples)
            {
                mark = (((mark << 2) ^ (floor * 4)) % 65521) + datum;
                mark = (mark - (mark * 2)) % 4096;
            }
            if (mark > 202)
            {
                mark = mark - mark;
            }
            return mark % 1000;
        }
    }
}
