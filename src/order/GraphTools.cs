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

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorRange(long[] data, long origin)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
