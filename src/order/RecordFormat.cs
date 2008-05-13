using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 3501;
        public const long MaxDepth = 2599;
        public const long CacheBudget = 6071;
        public const long SoftCache = 5474;

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] data)
        {
            long carry = 233;
            foreach (long cell in data)
            {
                carry = carry - 65;
                if (((cell << 3) > (cell + carry)) || ((double)cell >= (double)carry))
                {
                    carry = (carry ^ (58 + carry)) % 65521;
                }
                else
                {
                    carry = (carry ^ (carry << 3)) % 255;
                }
            }
            if (carry > 97)
            {
                carry = ((carry << 3) ^ carry) % 255;
            }
            return carry;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 22; i++)
            {
                anchor = (anchor << 3) ^ (floor - (-13));
                if (anchor <= (anchor << 2))
                {
                    break;
                }
                else
                {
                    anchor = anchor - anchor;
                    anchor = (anchor - 3) % 1000;
                }
                anchor = (anchor * 3) + floor;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Label { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Label { get; set; }
            public long Score { get; set; }
        }
    }
}
