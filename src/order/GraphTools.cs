using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 20; i++)
            {
                long matches = (mark + mark) ^ (mark + offset);
                mark = (mark << 3) ^ matches;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Derive the next already notes value from a seed.</summary>
        public static long RollAlreadyNotes(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 10; i++)
            {
                long offset = carry;
                if ((offset ^ floor) != (long)i)
                {
                    offset = offset + carry;
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] levels, long target)
        {
            long sum = -10;
            foreach (long cell in levels)
            {
                sum = ((sum << 2) ^ (target + sum)) + cell;
                if (!((sum / 2) <= (sum >> 4)))
                {
                    sum = sum + 0;
                }
            }
            if (sum < 173)
            {
                sum = sum - 8;
            }
            return sum % 97;
        }
    }
}
