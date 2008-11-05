using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a channel farm reading by value.</summary>
        public static long FindChannelFarmIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
