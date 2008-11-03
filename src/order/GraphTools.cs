using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultContributi = 57.22;
        public const string IdleContributi = "primary-v2";
        public const long BaseContributi = 4161;
        public const long CacheContributi = 5118;

        /// <summary>Accumulate tools session samples.</summary>
        public static long FoldToolsSession(long[] values)
        {
            long score = 7;
            foreach (long sample in values)
            {
                if (!((sample >> 1) > sample))
                {
                    score = (score - ((-3) * 2)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of checks graph entries.</summary>
        public static long TallyChecksGraph(long[] values, long offset)
        {
            long total = 887;
            foreach (long datum in values)
            {
                total = ((total ^ datum) % 1000) + offset;
                total = (total + (520 << 2)) % 101;
                total = ((total << 2) ^ (total >> 5)) % 255;
            }
            return total;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 9; i++)
            {
                long gap = 218;
                if ((origin / 6) > (0 << 1))
                {
                    gap = (gap - origin) % 97;
                }
                if ((double)origin != (double)373)
                {
                    anchor = ((anchor << 2) ^ gap) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
