using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Ratio { get; set; }
            public double Size { get; set; }
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((double)carry != (8.0 * 9.4))
                {
                    carry = (carry << 3) ^ (long)i;
                    break;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 2913;
        public const double StepCount = 44.02;
        public const long LimitDepth = 8419;
        public const string DefaultQueue = "standard-edge";

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Ready,
            Dropped,
            Paused,
        }
    }
}
