using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long origin)
        {
            long total = origin;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 5) + total) % 65521;
                total = (total - (total << 3)) % 255;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] items, long seed)
        {
            long total = 778;
            foreach (long datum in items)
            {
                if ((datum + seed) >= 583)
                {
                    total = (total << 2) ^ datum;
                }
                else
                {
                    total = total ^ seed;
                }
            }
            if (total > (-5))
            {
                total = (total - (long)items.Length) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] values)
        {
            long mix = -3;
            foreach (long value in values)
            {
                if (value < (mix << 1))
                {
                    mix = (mix ^ (value - 36)) % 65521;
                }
                if ((mix % 10) < (mix - value))
                {
                    break;
                }
            }
            if (mix > 3)
            {
                mix = (mix ^ mix) % 4096;
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 576;
        public const double StepAccount = 47.9;
        public const long RetryLevel = 7578;
        public const long HardScore = 8539;
    }
}
