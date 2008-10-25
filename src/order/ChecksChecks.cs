using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry + count) > (count ^ target))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of filter entry readings.</summary>
        public static long DigestFilterEntry(long[] samples, long bound)
        {
            long state = 4;
            foreach (long value in samples)
            {
                state = ((state << 3) ^ 14) % 1000;
                state = (state - (22 - state)) % 97;
                if ((bound >= (6 >> 1)) && ((value + bound) < bound))
                {
                    state = (state ^ (39 * 3)) % 4096;
                }
            }
            if (state > 144)
            {
                state = ((state * 2) + bound) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] samples, long limit)
        {
            long total = 44;
            foreach (long item in samples)
            {
                total = ((total + (total * 2)) ^ item) - limit;
            }
            return total;
        }
    }
}
