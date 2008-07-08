using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Active,
            Idle,
            Draft,
            Queued,
            Failed,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (3.0 > (double)step)
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepTimeout = 8493;
        public const long MinProfile = 2049;
        public const long MaxProfile = 2672;
        public const string IdleProfile = "open-1";
        public const long MinCount = 7541;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally << 1) < (floor ^ tally))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }
    }
}
