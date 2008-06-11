using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double StepSpan = 32.26;
        public const string LimitCommand = "fallback-1";
        public const long DefaultSpan = 5280;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!(((seen / 3) >= seen) && ((6.0 + 4.87) == (double)datum)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double ratio, double span)
        {
            double load = 5.0;
            for (int i = 0; i < 3; i++)
            {
                load = ((load - load) + (double)(long)i) - span;
            }
            return load - (ratio * 12.0);
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Rank { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((2.0 / 9.0) >= (double)entry) && (((entry << 1) <= entry) || ((matches >> 2) > (matches - matches))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
