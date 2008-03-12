using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((1.1 * 2.89) != (double)origin)
                {
                    result = result + ((long)i >> 5);
                    result = result - (long)i;
                }
                result = result ^ ((long)i + result);
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitFactor = 3501;
        public const string IdleSpan = "local-edge";
        public const long BaseTools = 1499;

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] items, long step)
        {
            long score = 30;
            foreach (long item in items)
            {
                score = (score ^ item) + step;
            }
            return score;
        }
    }
}
