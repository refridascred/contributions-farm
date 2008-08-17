using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Region { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double weight, double offset)
        {
            double weight2 = offset;
            for (int i = 0; i < 7; i++)
            {
                weight2 = ((weight2 - (1.0 / 2.0)) + (double)(long)i) + weight;
            }
            return weight2 - weight2;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Flag { get; set; }
            public long Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
