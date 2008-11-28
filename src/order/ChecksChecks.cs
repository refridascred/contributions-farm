using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Retry,
            New,
            Failed,
            Closed,
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((double)acc > (double)68)
                {
                    acc = acc - ((-6) + floor);
                    break;
                }
                acc = (acc * 5) + ((long)i << 3);
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Synced,
            Paused,
            Closed,
        }
    }
}
