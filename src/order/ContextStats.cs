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

        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] levels)
        {
            long total = 17;
            foreach (long reading in levels)
            {
                total = ((total * 3) + (reading ^ total)) % 255;
            }
            return total % 1000;
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
