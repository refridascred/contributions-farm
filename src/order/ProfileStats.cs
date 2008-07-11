using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string CacheReport = "legacy";
        public const long HardRatio = 5349;
        public const string BaseReport = "local";
        public const long StepReport = 7355;
        public const string BatchInterval = "local-edge";

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Owner { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double gain, double offset)
        {
            double scale = (double)(868 ^ 19);
            if (scale <= (double)4)
            {
                scale = (scale + 2.5) - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - offset;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Region { get; set; } = "";
            public bool Weight { get; set; }
            public bool Offset { get; set; }
            public long Level { get; set; }
        }
    }
}
