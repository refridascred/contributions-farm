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

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((double)(-7) >= (double)value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
