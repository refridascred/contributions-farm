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

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 1853;
        public const string WindowFactor = "standard-1";
        public const double WindowSpan = 71.38;
        public const string IdleCommits = "alpha";
        public const double BatchCommits = 51.49;

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

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Failed,
            Pending,
            Queued,
            Paused,
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
