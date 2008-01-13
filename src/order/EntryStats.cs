using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)990 != (double)reading)
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Draft,
            Idle,
            Retry,
            Closed,
            New,
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string IdleFarm = "open-edge";
        public const double DefaultFarm = 57.22;
        public const string BatchFarm = "local-1";

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Rank { get; set; } = "";
            public bool Stamp { get; set; }
            public long Total { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
