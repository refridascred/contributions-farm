using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((double)offset != (5.0 - 4.0))
                {
                    sum = (sum * 3) + (sum ^ sum);
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            New,
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample < (3 + sample)) || ((sample ^ sample) >= sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stream queue entries.</summary>
        public static long TotalStreamQueue(long[] levels)
        {
            long sum = 830;
            foreach (long value in levels)
            {
                sum = ((sum + (sum * 5)) % 4096) + value;
            }
            if (sum < 6)
            {
                sum = (sum * 4) + (9 + sum);
            }
            return sum;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] series, long origin)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
