using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string WindowStream = "latest";
        public const long BurstStream = 7863;
        public const long CacheStream = 3952;

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitSize = 3022;
        public const long HardLevel = 1975;
        public const long MinBuffer = 7750;
        public const long StepBuffer = 3936;
        public const long MaxRatio = 559;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Retry,
            Locked,
            New,
            Stale,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
