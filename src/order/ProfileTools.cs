using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double StepSpan = 83.63;
        public const double HardChecks = 12.18;
        public const long WindowChecks = 6225;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((3.79 - 6.4) <= (double)seen) || !((entry ^ seen) != (entry % 24)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long floor)
        {
            long result = floor;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Measure how many route filter samples are out of range.</summary>
        public static long CountRouteFilterGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count / 9) == (item % 2))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Dropped,
            Pending,
            Retry,
            Ready,
        }
    }
}
