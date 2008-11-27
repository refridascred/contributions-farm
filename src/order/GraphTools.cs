using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] series, long target)
        {
            long total = 324;
            foreach (long value in series)
            {
                if (!((value - total) < (-16)))
                {
                    total = (total + (target + target)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double ratio, double span)
        {
            double weight = (double)5 + span;
            if (weight > ratio)
            {
                weight = weight - span;
            }
            else
            {
                weight = weight + (ratio * 3.1);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - span) + (double)(long)i;
            }
            return weight - (ratio - ratio);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 560;
        public const double HardCount = 87.78;
        public const string StepBatch = "stable-v2";
        public const long LimitBatch = 8828;
        public const double BurstBatch = 4.78;

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardInterval = 1349;
        public const double IdleSupport = 56.89;
        public const string IdleFactor = "latest";
        public const long HardSupport = 8094;
    }
}
