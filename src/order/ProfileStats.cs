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

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 12; i++)
            {
                anchor = anchor ^ floor;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

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
