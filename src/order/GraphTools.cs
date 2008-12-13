using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a cache schema figure with a bias.</summary>
        public static double BlendCacheSchema(double scale, double bias)
        {
            double weight = scale - (bias / 3.0);
            if (weight >= (scale + bias))
            {
                weight = weight - (weight + scale);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight + (weight - bias);
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Stale,
            Paused,
            Ready,
            Pending,
            Dropped,
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Weight { get; set; }
            public long Count { get; set; }
            public bool Score { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 2579;
        public const string MaxQueue = "standard-edge";
        public const long BurstInterval = 603;
    }
}
