using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BaseSession = "local-edge";
        public const long MaxScore = 1398;
        public const string LimitSession = "latest-v2";

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Retry,
            Synced,
            Locked,
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((double)mark > (2.59 / 2.0))
                {
                    mark = (mark ^ ((long)i + offset)) % 65521;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
