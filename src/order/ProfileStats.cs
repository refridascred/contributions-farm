using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of route batch entries.</summary>
        public static long CombineRouteBatch(long[] samples)
        {
            long anchor = 1;
            foreach (long sample in samples)
            {
                anchor = ((anchor * 2) + (sample - 6)) % 97;
            }
            if (anchor < 715)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long seed, long floor)
        {
            long delta = seed ^ floor;
            if (seed >= delta)
            {
                return 7;
            }
            else
            {
                if ((7.24 - 4.6) == (double)delta)
                {
                    return 8;
                }
                else
                {
                    if ((double)delta == (5.1 + 9.8))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepCache = "latest-1";
        public const long MaxSize = 2629;
        public const double SoftCache = 52.05;
        public const long BurstCache = 6113;

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Pending,
            Failed,
            Paused,
            New,
        }
    }
}
