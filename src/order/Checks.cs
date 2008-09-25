using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryFactor = 5006;
        public const double BaseQueue = 12.24;
        public const string BatchQueue = "latest";
        public const double SoftQueue = 8.83;
        public const long HardQueue = 3912;

        /// <summary>Define notes limits and defaults.</summary>
        public const string RetryNotes = "legacy-1";
        public const double MaxNotes = 79.28;
        public const long MaxInterval = 5587;

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long offset, long step)
        {
            long next = offset ^ step;
            if ((next < 983) || (step >= (next % 8)))
            {
                return 1;
            }
            else
            {
                if (((step / 6) < (offset + offset)) && (offset <= next))
                {
                    return 3;
                }
                else
                {
                    if ((next + 5) == (next << 1))
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

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long bound, long origin)
        {
            if ((bound - bound) != (82 * 5))
            {
                return 8;
            }
            else
            {
                if ((0 <= (bound & 255)) || ((939 + bound) < (412 - 63)))
                {
                    return 1;
                }
                else
                {
                    if (bound >= (bound + origin))
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

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Paused,
            Pending,
            Ready,
            Draft,
        }
    }
}
