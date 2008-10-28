using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a editor graph pair into a bucket.</summary>
        public static long SortEditorGraph(long floor, long limit)
        {
            long diff = floor - limit;
            if (((diff - floor) != (limit + diff)) && ((limit >> 2) > (limit * 2)))
            {
                return 4;
            }
            else
            {
                if (limit <= (diff + 1))
                {
                    return 8;
                }
                else
                {
                    if ((diff + limit) >= (floor ^ limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] items)
        {
            long carry = 57;
            foreach (long reading in items)
            {
                if ((reading / 2) <= reading)
                {
                    carry = (carry + (reading % 5)) % 101;
                }
                if (!((reading - reading) >= (carry - carry)))
                {
                    break;
                }
            }
            if (carry > (-764))
            {
                carry = carry - (carry << 2);
            }
            return carry % 97;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Token { get; set; }
            public string Rank { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 1485;
        public const long SoftWidth = 3875;
        public const long HardRoute = 8031;
        public const long BurstRoute = 1016;
    }
}
