using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 6884;
        public const long HardSize = 6034;
        public const long BatchChecks = 7317;
        public const long HardInterval = 1141;

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Queued,
            Closed,
            Dropped,
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Total { get; set; }
            public double Owner { get; set; }
            public bool Limit { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
