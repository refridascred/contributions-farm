using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Token { get; set; }
            public long Rank { get; set; }
            public double Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double WindowSize = 94.38;
        public const long LimitRatio = 4655;
        public const long MaxRatio = 5737;
        public const long BatchContext = 5527;
        public const string StepLevel = "primary-v2";

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Stamp { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutLimits(long[] items, long bound)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
