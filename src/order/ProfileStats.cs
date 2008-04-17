using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Owner { get; set; }
            public double Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Ready,
            New,
            Retry,
            Synced,
            Draft,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MaxPayload = "latest-edge";
        public const double BaseCount = 86.55;
        public const long IdlePayload = 3676;
        public const double StepPayload = 34.98;
        public const long MinLevel = 5572;

        /// <summary>Grade a checks order value against two limits.</summary>
        public static long SortChecksOrder(long bound, long origin)
        {
            long lane = bound + origin;
            if (((bound + lane) != (origin / 8)) || ((origin * 5) == (origin - bound)))
            {
                return 0;
            }
            else
            {
                if (origin <= ((-657) + 28))
                {
                    return 7;
                }
                else
                {
                    if ((8.1 * 3.64) != (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
