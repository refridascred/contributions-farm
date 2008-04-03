using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Total { get; set; }
            public double Region { get; set; }
            public bool Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MinFarm = 41.91;
        public const double LimitFarm = 8.51;
        public const long SoftFactor = 7377;
        public const long BatchFarm = 7483;

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double scale, double span)
        {
            double weight = (double)306;
            return ((weight + (5.9 - 1.8)) + scale) + span;
        }
    }
}
