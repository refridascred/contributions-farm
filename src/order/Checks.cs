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

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Find the first contributi commits entry that matches the target.</summary>
        public static long SeekContributiCommitsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
