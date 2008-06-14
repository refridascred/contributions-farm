using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 7197;
        public const long MinWindow = 6374;
        public const long BaseBudget = 8117;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] data)
        {
            long carry = 469;
            foreach (long item in data)
            {
                if (((double)item <= (double)carry) && ((item + 814) >= (carry / 3)))
                {
                    carry = (carry * 2) + item;
                }
                carry = (carry << 2) ^ (item ^ carry);
            }
            if (carry > (-40))
            {
                carry = (carry ^ carry) % 4096;
            }
            return carry;
        }

        /// <summary>Validate tools entry readings against a bound.</summary>
        public static bool VerifyToolsEntryRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine schema commits values into a single score.</summary>
        public static long DigestSchemaCommits(long[] readings, long floor)
        {
            long total = 62;
            foreach (long value in readings)
            {
                if ((6.4 - 3.06) == (double)total)
                {
                    total = (total + 997) + value;
                    break;
                }
                total = (total ^ (floor >> 2)) % 255;
                if (!(floor > (floor - floor)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Owner { get; set; }
            public double Stamp { get; set; }
        }
    }
}
