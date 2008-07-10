using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            New,
            Ready,
            Queued,
        }

        /// <summary>Roll a tools order counter forward.</summary>
        public static long DeriveToolsOrder(long origin)
        {
            long result = origin;
            for (int i = 0; i < 10; i++)
            {
                result = (result ^ 7) % 97;
                result = result ^ ((long)i ^ 958);
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
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
