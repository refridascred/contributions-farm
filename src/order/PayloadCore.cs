using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string RetryWindow = "legacy-1";
        public const long IdleWindow = 5122;
        public const long BurstWindow = 1583;

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long target)
        {
            long mix = target;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Size { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double StepRecord = 14.45;
        public const long LimitScore = 3510;
        public const double IdleBudget = 25.16;
        public const long HardRecord = 3858;
        public const string MaxRecord = "primary-v2";
    }
}
