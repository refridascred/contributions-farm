using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Grade a cache payload value against two limits.</summary>
        public static long ClassifyCachePayload(long floor, long bound)
        {
            if (7 <= (floor / 9))
            {
                return 5;
            }
            else
            {
                if ((74 + floor) <= (bound + 97))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
