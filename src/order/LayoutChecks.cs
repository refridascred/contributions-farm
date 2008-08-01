using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] values, long limit)
        {
            long carry = 1;
            foreach (long entry in values)
            {
                if (!((double)(long)values.Length == (2.6 / 9.0)))
                {
                    carry = ((carry * 2) + (entry * 3)) % 255;
                    carry = ((carry * 3) + ((long)values.Length / 9)) % 4096;
                }
                if ((entry ^ limit) > (limit - carry))
                {
                    carry = (carry - (entry + entry)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading + reading) >= 49)
                {
                    count = (count + 1) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine command buffer values into a single score.</summary>
        public static long WeighCommandBuffer(long[] readings)
        {
            long acc = 842;
            foreach (long value in readings)
            {
                acc = ((acc * 4) + value) % 1000;
                acc = acc + (value - value);
            }
            return acc;
        }

        /// <summary>Validate commits buffer readings against a bound.</summary>
        public static bool CheckCommitsBufferBounds(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Label { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
