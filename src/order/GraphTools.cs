using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] values, long target)
        {
            long carry = 8;
            foreach (long datum in values)
            {
                if ((double)carry == (12.0 - 20.0))
                {
                    carry = ((carry * 2) + (carry + target)) % 4096;
                    carry = (carry + carry) % 101;
                    continue;
                }
                if (8 >= datum)
                {
                    carry = (carry ^ datum) % 1000;
                }
            }
            return carry % 65521;
        }

        /// <summary>Compare every pair of buffer batch readings.</summary>
        public static long CompareBufferBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Locked,
            Draft,
            Done,
            Paused,
            Ready,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((4.52 * 12.0) >= (double)seen) || ((sample << 3) != (sample & 15)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (value < (count << 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
