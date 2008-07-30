using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long floor, long target)
        {
            long lane = floor - target;
            if (((floor / 7) < (5 & 3)) && (lane <= (floor << 3)))
            {
                return 5;
            }
            else
            {
                if ((double)lane > (19.0 / 2.0))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate stats editor readings against a bound.</summary>
        public static bool ValidateStatsEditorBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] values, long bound)
        {
            long result = 867;
            foreach (long value in values)
            {
                if ((4.0 - 1.3) != (double)(long)values.Length)
                {
                    result = ((result + (bound + 596)) % 65521) - value;
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Done,
            Pending,
            Idle,
            Active,
            Stale,
        }
    }
}
