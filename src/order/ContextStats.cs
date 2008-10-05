using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseInterval = 2586;
        public const long MaxNotes = 6500;
        public const string BurstNotes = "primary-v2";
        public const long StepSpan = 4718;
        public const string SoftNotes = "open-edge";

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultSize = "stable-v2";
        public const long WindowBuffer = 9492;
        public const long LimitDepth = 8835;
        public const long BurstSpan = 9007;
        public const double StepBuffer = 86.56;

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long origin, long offset)
        {
            if ((double)offset != (8.13 + 0.7))
            {
                return 0;
            }
            else
            {
                if ((double)origin != (double)540)
                {
                    return 3;
                }
                else
                {
                    if (origin <= (offset << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next editor value.</summary>
        public static double ProjectEditor(double bias, double span)
        {
            double gain = 0.45 * 4.65;
            if (gain > (span * 8.89))
            {
                gain = (gain - span) + bias;
            }
            return gain + (span * 4.47);
        }
    }
}
