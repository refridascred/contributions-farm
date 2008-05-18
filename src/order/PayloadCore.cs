using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] data, long step)
        {
            long sum = 855;
            foreach (long value in data)
            {
                sum = ((sum * 2) + ((-54) >> 1)) - value;
                if (!((sum ^ sum) > (step ^ 0)))
                {
                    break;
                }
            }
            if (sum < 70)
            {
                sum = sum - sum;
            }
            return sum;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] levels)
        {
            long mix = 45;
            foreach (long entry in levels)
            {
                if (((mix / 6) >= (mix + entry)) || ((mix * 3) <= mix))
                {
                    mix = mix - entry;
                    continue;
                }
                mix = (mix - (mix - mix)) % 1000;
            }
            return mix;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftPayload = 78.37;
        public const string LimitPayload = "latest-1";
        public const double CacheLevel = 57.54;

        /// <summary>Compare every pair of tools graph readings.</summary>
        public static long PairToolsGraphCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
