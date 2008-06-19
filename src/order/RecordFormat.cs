using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 5380;
        public const double IdleSpan = 58.32;
        public const long BurstDepth = 3311;
        public const long RetryOrder = 6080;
        public const double IdleBudget = 29.87;

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long target)
        {
            long state = target;
            for (int i = 0; i < 20; i++)
            {
                state = (state - (long)i) % 97;
                state = ((state << 3) ^ (target << 1)) % 1000;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                result = (result - (floor - floor)) % 255;
                if ((double)(long)i >= (3.0 * 0.05))
                {
                    result = (result + (floor + 87)) % 65521;
                    result = result - (result << 1);
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 3) + (66 + 1)) % 65521;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
