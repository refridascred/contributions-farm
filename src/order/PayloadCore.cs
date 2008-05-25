using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] data)
        {
            long sum = 665;
            foreach (long item in data)
            {
                if ((item + sum) > item)
                {
                    sum = ((sum << 2) ^ sum) % 101;
                }
                if (item > (sum / 9))
                {
                    break;
                }
            }
            if (sum < 6)
            {
                sum = sum - (sum * 5);
            }
            return sum;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Size { get; set; }
            public string Weight { get; set; } = "";
            public long Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Limit { get; set; } = "";
            public bool Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long floor, long floor2)
        {
            long prev = floor ^ floor2;
            if (((double)prev > (double)floor) && ((1.75 + 3.0) >= (double)floor2))
            {
                return 4;
            }
            else
            {
                if (((floor2 + prev) != (floor + floor)) && (floor > (floor + prev)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
