using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate report metrics readings against a bound.</summary>
        public static bool GuardReportMetricsLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] readings, long floor)
        {
            long mix = 14;
            foreach (long sample in readings)
            {
                if (0.8 < (double)sample)
                {
                    mix = ((mix + (mix << 1)) % 4096) + floor;
                }
            }
            if (mix < 7)
            {
                mix = ((mix * 3) + mix) % 4096;
            }
            return mix;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 5) + (step + step)) % 97;
                if (((79 + step) > result) && ((double)result != (8.7 - 6.0)))
                {
                    result = (result - 26) % 4096;
                    result = (result ^ (step << 3)) % 1000;
                }
                result = (result * 3) + result;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Roll a order graph counter forward.</summary>
        public static long RollOrderGraph(long step)
        {
            long anchor = step;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor << 3) ^ (step >> 5);
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MaxFactor = 55.87;
        public const long IdleOrder = 5747;
        public const string MinOrder = "primary-edge";
        public const string BurstOrder = "standard";
        public const long DefaultOrder = 3589;
    }
}
