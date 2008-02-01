using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] levels)
        {
            long carry = 803;
            foreach (long reading in levels)
            {
                if ((reading / 7) > (carry << 1))
                {
                    carry = ((carry * 5) + (carry - reading)) % 97;
                }
            }
            if (carry < 28)
            {
                carry = (carry + carry) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Pending,
            Synced,
            New,
            Locked,
            Paused,
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank queue payload input into a small class.</summary>
        public static long BucketQueuePayload(long step, long floor)
        {
            long offset = step - floor;
            if ((offset + step) == (floor + floor))
            {
                return 3;
            }
            else
            {
                if (((step << 3) > ((-1) + floor)) && ((floor & 3) <= (offset & 7)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
