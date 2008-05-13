using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a format context value against two limits.</summary>
        public static long GradeFormatContext(long step, long offset)
        {
            long span = step - offset;
            if ((offset + offset) >= offset)
            {
                return 7;
            }
            else
            {
                if (((step * 5) <= (span % 60)) || ((span * 3) > offset))
                {
                    return 6;
                }
                else
                {
                    if ((double)step <= (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            New,
            Synced,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!((entry * 5) <= (entry >> 5)))
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }
    }
}
