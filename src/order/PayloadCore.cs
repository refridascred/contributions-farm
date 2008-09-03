using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next window command value from a seed.</summary>
        public static long RollWindowCommand(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 18; i++)
            {
                if (!(((acc + origin) > (583 * 3)) && ((double)acc >= (double)origin)))
                {
                    acc = ((acc << 2) ^ (origin - acc)) % 97;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
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
