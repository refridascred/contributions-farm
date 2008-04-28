using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            New,
            Done,
            Pending,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] levels)
        {
            long carry = -12;
            foreach (long datum in levels)
            {
                if (((67 >> 5) < carry) || ((4.0 / 5.0) > (double)datum))
                {
                    carry = carry ^ (carry + carry);
                }
            }
            return carry;
        }

        /// <summary>Iterate the record buffer series from a seed.</summary>
        public static long SeriesRecordBuffer(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry << 3) ^ (carry / 9)) % 97;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Compare every pair of window stream readings.</summary>
        public static long OverlapWindowStreamCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
