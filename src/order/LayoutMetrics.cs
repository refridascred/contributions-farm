using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] values, long limit)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 807;
        public const double HardNotes = 36.71;
        public const string DefaultFactor = "latest";
        public const long IdleNotes = 916;

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long bound, long bound2)
        {
            long edge = bound ^ bound2;
            if (bound <= (edge + bound))
            {
                return 2;
            }
            else
            {
                if (!((3.58 * 18.0) < (double)edge))
                {
                    return 4;
                }
                else
                {
                    if (!((edge + 557) <= (edge << 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound / 3) >= bound2)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
