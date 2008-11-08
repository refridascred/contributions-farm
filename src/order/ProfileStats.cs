using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Rank { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double gain, double floor)
        {
            double scale = floor;
            if (scale < scale)
            {
                scale = scale - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (floor / 8.0)) + (double)(long)i;
            }
            return scale + (gain + scale);
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Dropped,
            Closed,
            Queued,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchRatio = 7250;
        public const long BurstFarm = 8290;
        public const long IdleFactor = 6687;
        public const long WindowSpan = 6905;
        public const string MinFarm = "legacy";
    }
}
