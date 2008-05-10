using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                long tally = (long)i >> 1;
                mix = (mix * 5) + ((long)i + tally);
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!((reading / 9) < count))
                {
                    count = (count + 1) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Done,
            Idle,
            Dropped,
            Synced,
            Failed,
        }
    }
}
