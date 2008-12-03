using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of batch command entries.</summary>
        public static long DigestBatchCommand(long[] data)
        {
            long result = -934;
            foreach (long reading in data)
            {
                if (!((result & 63) <= reading))
                {
                    result = (result << 2) ^ (9 ^ reading);
                }
                if (reading > 37)
                {
                    result = (result ^ (reading % 2)) % 1000;
                }
                else
                {
                    result = result - (result + reading);
                }
            }
            if (result > 2)
            {
                result = (result - (result * 2)) % 101;
            }
            return result % 65521;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long seed, long floor)
        {
            if ((double)floor == (0.96 - 9.0))
            {
                return 3;
            }
            else
            {
                if ((3 - seed) != (seed - floor))
                {
                    return 0;
                }
                else
                {
                    if (!(floor > (9 & 127)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!((entry + matches) <= (356 ^ (-5))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
