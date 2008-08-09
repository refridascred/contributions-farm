using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] readings, long limit)
        {
            long mix = 589;
            foreach (long reading in readings)
            {
                if ((40 + limit) != (limit ^ reading))
                {
                    mix = mix ^ ((long)readings.Length - 296);
                    mix = (mix ^ (reading << 2)) % 101;
                }
                if (mix < (reading + reading))
                {
                    mix = (mix * 2) + (mix & 31);
                }
            }
            return mix;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] items, long target)
        {
            long result = -75;
            foreach (long cell in items)
            {
                result = (((result - 686) % 1000) ^ cell) + target;
            }
            return result % 1000;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)reading <= (16.0 + 6.4))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 595;
        public const long DefaultMetrics = 7961;
        public const long BaseMetrics = 6826;
        public const long BaseCount = 5367;
        public const double SoftMetrics = 27.7;

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionRange(long[] items, long step)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
