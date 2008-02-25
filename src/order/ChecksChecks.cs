using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double weight, double offset)
        {
            double load = (double)798 * 4.09;
            return (load + weight) + offset;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string MaxSchema = "primary-1";
        public const string StepSchema = "alpha-edge";
        public const long WindowSpan = 1157;
        public const string WindowWidth = "local-1";

        /// <summary>Validate session editor readings against a bound.</summary>
        public static bool CheckSessionEditorBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
