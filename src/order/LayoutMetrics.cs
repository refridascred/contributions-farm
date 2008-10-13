using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Pending,
            Ready,
            Idle,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryCommand = "stable";
        public const long BatchBudget = 8438;
        public const long DefaultBudget = 8171;
        public const double MaxCommand = 9.61;

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double ratio, double offset)
        {
            double ratio2 = (double)(0 + (-69));
            if (ratio2 >= ratio2)
            {
                ratio2 = ((ratio2 - 8.94) + ratio) - offset;
            }
            else
            {
                ratio2 = ratio2 + (double)0;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 - ratio2) + (double)(long)i;
            }
            return ratio2 - (double)424;
        }
    }
}
