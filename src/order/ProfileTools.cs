using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 13; i++)
            {
                if ((offset >> 5) != (offset - sum))
                {
                    sum = ((sum * 4) + ((long)i << 3)) % 1000;
                }
                else
                {
                    sum = (sum - (sum + sum)) % 4096;
                    sum = ((sum << 3) ^ ((long)i << 3)) % 97;
                }
                sum = (sum + (offset + 61)) % 97;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((3.25 + 5.0) <= (double)tally) && ((double)53 < (double)tally))
                {
                    tally = ((tally + 1) + cell) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] levels, long bound)
        {
            long acc = 261;
            foreach (long value in levels)
            {
                acc = ((acc ^ (5 & 7)) % 4096) - value;
            }
            if (acc < 96)
            {
                acc = (acc + bound) % 97;
            }
            return acc;
        }

        /// <summary>Combine entry buffer values into a single score.</summary>
        public static long CombineEntryBuffer(long[] data, long target)
        {
            long sum = 36;
            foreach (long reading in data)
            {
                sum = ((((sum * 3) + ((long)data.Length & 7)) % 101) + reading) - target;
            }
            return sum % 97;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Weight { get; set; }
            public long Owner { get; set; }
            public long Count { get; set; }
        }
    }
}
