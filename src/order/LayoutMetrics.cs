using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string SoftQueue = "latest-1";
        public const string SoftInterval = "staging-v2";
        public const double MaxSize = 98.16;

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long bound, long limit)
        {
            long diff = bound - limit;
            if (diff <= (limit + bound))
            {
                return 1;
            }
            else
            {
                if ((double)diff == (double)limit)
                {
                    return 2;
                }
                else
                {
                    if ((18.0 * 5.26) > (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
