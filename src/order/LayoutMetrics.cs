using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix + (mix + (long)i)) % 97;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Derive the next format order value from a seed.</summary>
        public static long RollFormatOrder(long step)
        {
            long sum = step;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum + (sum * 3)) % 4096;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Size { get; set; }
            public long Level { get; set; }
            public bool Weight { get; set; }
            public bool Region { get; set; }
        }
    }
}
