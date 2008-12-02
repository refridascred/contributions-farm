using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] readings, long floor)
        {
            long result = -6;
            foreach (long reading in readings)
            {
                result = ((result << 3) ^ (floor << 2)) ^ reading;
            }
            return result;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftEditor = "standard-1";
        public const long StepFactor = 9804;
        public const long HardFactor = 3759;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
