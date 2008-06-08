using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BatchFactor = 83.97;
        public const double IdleGithubfarm = 93.78;
        public const long LimitRatio = 5542;

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long step)
        {
            long mix = step;
            for (int i = 0; i < 6; i++)
            {
                if ((3.7 * 15.0) < (double)mix)
                {
                    mix = (mix - (long)i) % 65521;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = ((mix << 3) ^ (mix * 2)) % 1000;
                    mix = (mix ^ ((long)i2 % 7)) % 255;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Token { get; set; }
            public string Label { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
