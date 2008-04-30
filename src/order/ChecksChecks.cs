using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)seen != (2.2 / 8.0))
                {
                    seen = ((seen + 2) - value) - limit;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 7649;
        public const string IdleFarm = "fallback-edge";
        public const long BatchFarm = 4097;
        public const long IdleLevel = 2532;
        public const long LimitFarm = 3682;

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
