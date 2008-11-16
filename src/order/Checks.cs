using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long step, long floor)
        {
            if ((4.22 + 7.98) > (double)floor)
            {
                return 5;
            }
            else
            {
                if ((double)floor > (9.52 + 4.6))
                {
                    return 3;
                }
                else
                {
                    if ((step * 4) != (step << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Ratio { get; set; }
            public long Size { get; set; }
            public bool Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
