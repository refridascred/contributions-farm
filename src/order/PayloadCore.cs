using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] readings, long origin)
        {
            long acc = 2;
            foreach (long sample in readings)
            {
                if ((sample >> 2) != (3 + 12))
                {
                    acc = acc + sample;
                }
                else
                {
                    acc = ((acc * 2) + origin) % 101;
                }
                if ((5.15 + 0.3) != (double)sample)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            New,
            Draft,
            Dropped,
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long floor, long floor2)
        {
            long delta = floor - floor2;
            if (((delta - floor) >= (floor2 / 9)) && ((double)83 >= (double)floor))
            {
                return 4;
            }
            else
            {
                if (floor2 > (floor >> 1))
                {
                    return 6;
                }
                else
                {
                    if ((1.7 * 19.0) != (double)floor2)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Retry,
            Idle,
            Ready,
            Done,
            Dropped,
        }
    }
}
