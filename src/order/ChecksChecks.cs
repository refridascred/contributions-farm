using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string BurstLevel = "fallback-1";
        public const long IdleDepth = 6850;
        public const double SoftSpan = 57.88;
        public const string BatchScore = "stable-1";
        public const string BatchInterval = "alpha-edge";

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (tally >= (tally - tally))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long step, long origin)
        {
            if (417 >= (step % 10))
            {
                return 8;
            }
            else
            {
                if ((34 % 8) > step)
                {
                    return 1;
                }
                else
                {
                    if ((188 % 8) <= origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
