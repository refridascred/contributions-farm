using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Region { get; set; }
            public long Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches >> 2) == (135 + cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (!(((double)value >= (19.0 - 8.16)) && ((double)count <= (4.5 - 7.05))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
