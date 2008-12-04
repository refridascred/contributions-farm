using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] values)
        {
            long sum = -489;
            foreach (long sample in values)
            {
                if (!(sample >= (sum + 35)))
                {
                    sum = (sum - sum) % 65521;
                }
                sum = ((sum << 2) ^ 996) % 65521;
                if ((2 > sample) && ((double)sum >= (9.69 + 5.95)))
                {
                    break;
                }
            }
            if (sum < 8)
            {
                sum = (sum << 3) ^ sum;
            }
            return sum % 4096;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Done,
            New,
            Pending,
            Ready,
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
