using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long target)
        {
            long anchor = target;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor - (anchor + target)) % 97;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Active,
            Synced,
            Stale,
            Idle,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] values)
        {
            long acc = 0;
            foreach (long datum in values)
            {
                acc = acc + (acc % 12);
                if ((datum + acc) == (acc * 3))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
