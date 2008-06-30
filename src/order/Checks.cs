using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Weight { get; set; } = "";
            public double Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] readings)
        {
            long total = 187;
            foreach (long cell in readings)
            {
                if (!((cell - cell) >= (cell + total)))
                {
                    total = total + (9 >> 1);
                }
                else
                {
                    total = (total - (cell % 97)) % 4096;
                }
            }
            if (total < 1)
            {
                total = (total ^ (94 >> 2)) % 97;
            }
            return total;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 17; i++)
            {
                long edge = ((long)i & 15) - (carry + carry);
                if ((8.29 * 0.1) <= (double)origin)
                {
                    carry = carry + (carry + edge);
                    break;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
