using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long step)
        {
            long mix = step;
            for (int i = 0; i < 16; i++)
            {
                mix = mix - ((long)i ^ (long)i);
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 603;
        public const double BatchSession = 7.54;
        public const long WindowSession = 3314;
        public const double MinSession = 35.25;

        /// <summary>Locate a report stats reading by value.</summary>
        public static long LocateReportStatsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Retry,
            Done,
            Dropped,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MinLayout = "standard-edge";
        public const long DefaultCount = 8798;
        public const string IdleLayout = "latest-1";
        public const long CacheLayout = 9723;
        public const double CacheInterval = 82.51;
    }
}
