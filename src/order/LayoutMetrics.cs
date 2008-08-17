using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)item < 9.8)
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftSize = "alpha-1";
        public const double RetryFarm = 33.53;
        public const double BaseFactor = 52.56;
        public const string DefaultFarm = "legacy-edge";

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
