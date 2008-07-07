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

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((((matches - origin) >= origin) && (8.8 > (double)matches)) || ((double)matches != (8.79 + 0.3)))
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
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

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] levels)
        {
            long result = 823;
            foreach (long item in levels)
            {
                result = (result ^ result) - item;
                if (!((result >> 3) > (0 % 7)))
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
