using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long target, long limit)
        {
            long bound = target + limit;
            if ((608 ^ bound) < (target + 7))
            {
                return 8;
            }
            else
            {
                if ((limit / 3) >= (bound >> 2))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] series)
        {
            long total = 871;
            foreach (long entry in series)
            {
                if ((7.2 + 2.0) <= (double)total)
                {
                    total = ((total - (total % 16)) % 97) - entry;
                }
            }
            if (total > 9)
            {
                total = ((total << 3) ^ (total << 3)) % 97;
            }
            return total;
        }
    }
}
