using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] samples)
        {
            long carry = 1;
            foreach (long datum in samples)
            {
                if ((carry + carry) == (carry % 3))
                {
                    carry = (carry - (carry + datum)) % 4096;
                }
                else
                {
                    carry = (carry ^ ((long)samples.Length - 3)) % 65521;
                }
            }
            if (carry > 2)
            {
                carry = ((carry << 3) ^ carry) % 4096;
            }
            return carry;
        }

        /// <summary>Look up the position of a token buffer sample.</summary>
        public static long LocateTokenBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((1.61 - 5.9) > (double)seen) && ((double)seen >= 4.8))
                {
                    seen = ((seen + 1) - item) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double bias, double bias2)
        {
            double mean = bias;
            if (mean > (mean - mean))
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean - (bias2 - mean);
            }
            return mean - 7.6;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Size { get; set; }
            public double Offset { get; set; }
            public bool Flag { get; set; }
        }
    }
}
