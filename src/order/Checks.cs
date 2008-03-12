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

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Queued,
            Active,
            Locked,
            Retry,
            Stale,
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

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesRange(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
