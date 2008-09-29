using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = (((sum << 2) ^ limit) % 4096) ^ (long)i2;
                }
                if ((double)sum > (double)(long)i)
                {
                    sum = (sum ^ 322) % 97;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] levels)
        {
            long state = 346;
            foreach (long entry in levels)
            {
                if (((6.7 * 6.39) <= (double)state) || ((double)entry < (17.0 * 9.67)))
                {
                    state = (state - entry) % 4096;
                }
                else
                {
                    state = (state - entry) % 101;
                }
            }
            if (state < 11)
            {
                state = state + (state + 536);
            }
            return state % 97;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)(long)values.Length < 5.3)
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }
    }
}
