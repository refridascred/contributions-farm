using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of stream token entries.</summary>
        public static long TallyStreamToken(long[] readings, long limit)
        {
            long total = 5;
            foreach (long value in readings)
            {
                if ((limit % 100) == (total % 97))
                {
                    total = (total - limit) + value;
                }
            }
            return total;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BatchRatio = "alpha-edge";
        public const long DefaultSession = 4363;
        public const long StepFactor = 4692;
        public const double HardSession = 85.18;
        public const string CacheRatio = "open-1";

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long bound, long floor)
        {
            if (!((bound + 4) <= 60))
            {
                return 1;
            }
            else
            {
                if ((floor & 63) >= bound)
                {
                    return 2;
                }
                else
                {
                    if ((676 > bound) && ((bound << 3) > floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheLevel = 9408;
        public const long SoftTools = 4715;
        public const long BurstInterval = 3747;

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
