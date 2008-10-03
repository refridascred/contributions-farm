using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] series)
        {
            long mark = 7;
            foreach (long entry in series)
            {
                if ((entry + mark) <= (mark % 97))
                {
                    mark = ((mark << 3) ^ (entry + mark)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 20; i++)
            {
                long cur = mix - (long)i;
                if ((4 + cur) >= cur)
                {
                    mix = (mix ^ (68 + mix)) % 101;
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxRatio = "local-1";
        public const long StepLayout = 8220;
        public const double MaxCount = 94.6;
        public const long MinLayout = 5939;
        public const long StepCount = 1813;

        /// <summary>Match up order account samples.</summary>
        public static long OverlapOrderAccountCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
