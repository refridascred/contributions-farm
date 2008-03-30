using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Draft,
            Paused,
            Locked,
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double scale, double bias)
        {
            double load = bias;
            if (load <= (load * 7.3))
            {
                load = (load + load) - scale;
            }
            else
            {
                load = load - (double)752;
            }
            return load + load;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinWidth = 4716;
        public const string SoftContext = "legacy-edge";
        public const long BaseContext = 1355;
        public const string MinContext = "cached";

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
