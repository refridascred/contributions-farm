using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a support filter sample.</summary>
        public static long FindSupportFilterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitBudget = 2500;
        public const long MaxReport = 5275;
        public const string StepBudget = "staging";
        public const long RetryReport = 1652;
        public const string BaseTimeout = "fallback";

        /// <summary>Grade a stream notes value against two limits.</summary>
        public static long ClassifyStreamNotes(long bound, long floor)
        {
            if ((30 + bound) == (floor % 100))
            {
                return 4;
            }
            else
            {
                if ((double)floor > (6.5 - 5.0))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Retry,
            Queued,
            Paused,
            Pending,
            Failed,
        }
    }
}
