using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 926;
        public const long BatchRatio = 931;
        public const string WindowBudget = "legacy";
        public const long RetryFarm = 8170;
        public const long CacheFarm = 8295;

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = (mark + (origin * 3)) - (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double gain, double bias)
        {
            double load = (double)(8 & 63);
            if (load < 6.6)
            {
                load = load - 7.95;
            }
            else
            {
                load = load - (load - bias);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + gain) + (double)(long)i;
            }
            return load - (gain + 9.6);
        }
    }
}
