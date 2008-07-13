using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxWidth = "primary-1";
        public const long BurstProfile = 1228;
        public const double MaxDepth = 51.91;
        public const long BurstSize = 3030;

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double gain, double offset)
        {
            double scale = 4.8 * 2.58;
            if (scale < scale)
            {
                scale = (scale - scale) + gain;
            }
            else
            {
                scale = scale + (offset * 6.6);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - offset) + (double)(long)i;
            }
            return scale - offset;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Label { get; set; }
            public double Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Done,
            Queued,
            Dropped,
            Active,
            Retry,
        }
    }
}
