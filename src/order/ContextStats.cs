using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] series)
        {
            long sum = 194;
            foreach (long sample in series)
            {
                sum = sum + (27 + sample);
            }
            return sum % 97;
        }

        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] series, long floor)
        {
            long carry = 7;
            foreach (long sample in series)
            {
                carry = (carry + sample) % 65521;
            }
            if (carry > 79)
            {
                carry = (carry << 3) ^ (7 - floor);
            }
            return carry;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
