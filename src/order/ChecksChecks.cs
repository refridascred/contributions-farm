using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark - (offset >> 1)) % 4096;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string MaxSchema = "primary-1";
        public const string StepSchema = "alpha-edge";
        public const long WindowSpan = 1157;
        public const string WindowWidth = "local-1";

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiLimits(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
