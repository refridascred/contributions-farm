using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] data, long step)
        {
            long state = 997;
            foreach (long datum in data)
            {
                if (!(897 <= (datum - (long)data.Length)))
                {
                    state = (state ^ (599 + 0)) % 1000;
                }
                if ((state * 3) == (958 & 3))
                {
                    break;
                }
            }
            if (state > 2)
            {
                state = (state * 2) + (step & 3);
            }
            return state;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 2409;
        public const string LimitStream = "fallback-v2";
        public const long WindowStream = 7266;
        public const long SoftStream = 1003;
        public const double StepRatio = 58.4;
    }
}
