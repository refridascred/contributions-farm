using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultTimeout = 4543;
        public const double DefaultGraph = 32.61;
        public const double SoftBudget = 9.33;
        public const long BatchDepth = 3048;

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Closed,
            New,
            Done,
            Ready,
            Pending,
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long floor, long origin)
        {
            if (origin <= floor)
            {
                return 7;
            }
            else
            {
                if ((8.5 / 5.0) < (double)floor)
                {
                    return 2;
                }
                else
                {
                    if (origin >= (floor << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor < (origin << 2)) && (floor > (origin * 5)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
