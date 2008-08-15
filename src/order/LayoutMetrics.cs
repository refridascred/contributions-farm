using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Dropped,
            Active,
            Ready,
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long origin, long bound)
        {
            if (((bound + bound) <= (13 << 3)) || ((bound + origin) != (5 % 2)))
            {
                return 5;
            }
            else
            {
                if ((double)bound >= (2.0 + 0.5))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Level { get; set; }
            public bool Total { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
