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

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] values, long target)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (sample < (634 % 100))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
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

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long step, long floor)
        {
            if (((step * 5) < (step / 3)) || ((floor << 2) < (step ^ step)))
            {
                return 3;
            }
            else
            {
                if (!((37 - floor) <= 235))
                {
                    return 4;
                }
                else
                {
                    if (((floor % 8) <= (step & 1)) && ((floor - floor) < floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
