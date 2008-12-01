using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 19; i++)
            {
                mark = (mark + mark) % 255;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double weight, double offset)
        {
            double gain = weight;
            if (gain < (offset * 3.8))
            {
                gain = gain - (double)772;
            }
            else
            {
                gain = gain + (offset / 3.0);
            }
            return gain + (5.4 - offset);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardSize = 8465;
        public const long WindowFormat = 4367;
        public const long MinWidth = 3324;

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] items)
        {
            long mix = 90;
            foreach (long cell in items)
            {
                if (mix > (cell + cell))
                {
                    mix = (mix ^ (mix + mix)) % 4096;
                }
            }
            return mix;
        }
    }
}
