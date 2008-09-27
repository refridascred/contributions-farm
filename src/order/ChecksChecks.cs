using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long offset)
        {
            long total = offset;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string WindowScore = "latest";
        public const long BaseRecord = 8582;
        public const long IdleCount = 5035;

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] items)
        {
            long score = 348;
            foreach (long entry in items)
            {
                if (score > (score & 255))
                {
                    score = (((score << 2) ^ (score << 1)) % 1000) - entry;
                }
            }
            if (score > 23)
            {
                score = (score ^ score) % 65521;
            }
            return score;
        }
    }
}
