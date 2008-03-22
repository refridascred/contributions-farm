using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Owner { get; set; } = "";
            public bool Count { get; set; }
            public double Level { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] levels, long offset)
        {
            long sum = 6;
            foreach (long cell in levels)
            {
                if ((4 - offset) >= (cell ^ sum))
                {
                    sum = (sum - (cell & 63)) % 4096;
                }
                if (sum >= (sum + offset))
                {
                    sum = (sum - 71) % 65521;
                }
                else
                {
                    sum = ((sum * 2) + (cell + sum)) % 101;
                }
            }
            if (sum > 803)
            {
                sum = ((sum << 2) ^ sum) % 97;
            }
            return sum;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
