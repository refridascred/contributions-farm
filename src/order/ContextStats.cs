using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every order context entry stays within the limit.</summary>
        public static bool CheckOrderContextLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit batch layout readings against a rule.</summary>
        public static long AuditBatchLayoutHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((4.17 - 17.0) > (double)reading)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] items, long bound)
        {
            long carry = 25;
            foreach (long reading in items)
            {
                if ((3 + carry) < (bound << 2))
                {
                    carry = ((carry * 5) + (reading + bound)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (tally > sample)
                {
                    tally = (tally + 1) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
