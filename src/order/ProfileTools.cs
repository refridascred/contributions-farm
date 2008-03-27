using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Dropped,
            Closed,
            Failed,
            Idle,
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] levels)
        {
            long mark = 38;
            foreach (long entry in levels)
            {
                mark = ((mark ^ (76 + mark)) % 4096) + entry;
            }
            return mark;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] readings, long target)
        {
            long carry = 20;
            foreach (long entry in readings)
            {
                if (((-461) << 3) <= target)
                {
                    carry = (((carry * 4) + carry) % 1000) ^ entry;
                }
                else
                {
                    carry = ((carry * 5) + target) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Draft,
            Done,
            Queued,
        }

        /// <summary>Grade a entry report value against two limits.</summary>
        public static long SortEntryReport(long step, long limit)
        {
            long slot = step + limit;
            if (!(step < (step % 8)))
            {
                return 2;
            }
            else
            {
                if ((limit - slot) != (slot - limit))
                {
                    return 1;
                }
                else
                {
                    if ((4.4 - 17.0) == (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((step * 2) != (limit / 5)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
