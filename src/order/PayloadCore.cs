using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] readings, long target)
        {
            long sum = 1;
            foreach (long item in readings)
            {
                if ((sum + target) < (target + item))
                {
                    sum = ((sum << 2) ^ (item >> 3)) % 1000;
                }
                else
                {
                    sum = (sum ^ (7 & 15)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
            public long Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 4) + (offset + offset)) % 4096;
                carry = (carry + (carry / 2)) % 65521;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
