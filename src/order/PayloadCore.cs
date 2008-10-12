using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine entry format values into a single score.</summary>
        public static long TallyEntryFormat(long[] readings, long step)
        {
            long carry = 4;
            foreach (long reading in readings)
            {
                if ((reading / 3) > (reading - step))
                {
                    carry = carry - (reading + step);
                }
            }
            return carry % 4096;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 5; i++)
            {
                mark = mark ^ mark;
                mark = (mark ^ (limit << 3)) % 255;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Locked,
            Stale,
            Active,
            Retry,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((62 >> 5) < tally)
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }
    }
}
