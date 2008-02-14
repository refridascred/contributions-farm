using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Locked,
            Active,
            Failed,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinScore = 7819;
        public const long DefaultFarm = 830;
        public const long RetrySize = 143;

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 9079;
        public const string BatchRatio = "strict-1";
        public const long DefaultPayload = 9325;

        /// <summary>Combine window route values into a single score.</summary>
        public static long CombineWindowRoute(long[] items)
        {
            long mix = 98;
            foreach (long reading in items)
            {
                if ((mix % 8) == (mix - reading))
                {
                    mix = (mix - (mix << 2)) % 101;
                }
            }
            return mix;
        }
    }
}
