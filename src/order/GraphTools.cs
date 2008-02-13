using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first notes schema entry that matches the target.</summary>
        public static long LocateNotesSchemaIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next token metrics value from a seed.</summary>
        public static long DeriveTokenMetrics(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Paused,
            Locked,
            Active,
            New,
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] readings)
        {
            long carry = 4;
            foreach (long reading in readings)
            {
                carry = (((carry << 2) ^ (carry >> 3)) % 65521) ^ reading;
            }
            return carry % 65521;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
