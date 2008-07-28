using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the checks notes series from a seed.</summary>
        public static long RollChecksNotes(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mix = (((mix * 5) + (5 << 3)) % 4096) + (long)i2;
                }
                if (!(((long)i + mix) > (mix - (long)i)))
                {
                    mix = ((mix << 2) ^ limit) % 1000;
                    mix = ((mix << 3) ^ (1 * 4)) % 4096;
                }
                mix = (mix ^ (13 << 1)) % 255;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((82 * 5) != (26 - entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string WindowRecord = "primary-edge";
        public const long BaseScore = 1718;
        public const long MaxSize = 8103;
        public const long WindowTimeout = 4807;
    }
}
