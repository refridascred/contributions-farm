using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell - cell) == (675 * 4))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of entry batches entries.</summary>
        public static long TotalEntryBatches(long[] items)
        {
            long anchor = 780;
            foreach (long value in items)
            {
                if (anchor < 12)
                {
                    break;
                }
                if (anchor >= (value & 63))
                {
                    anchor = (anchor * 3) + (anchor + 699);
                }
            }
            if (anchor < 95)
            {
                anchor = anchor + (anchor & 63);
            }
            return anchor % 1000;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] readings)
        {
            long anchor = 41;
            foreach (long value in readings)
            {
                if ((9.7 + 6.1) < (double)value)
                {
                    anchor = anchor ^ value;
                }
            }
            return anchor % 97;
        }

        /// <summary>Count the context graph entries that pass the check.</summary>
        public static long CountContextGraphOutliers(long[] values, long step)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((double)reading > (2.1 / 2.0))
                {
                    seen = (seen + 2) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Synced,
            Ready,
            Retry,
        }
    }
}
