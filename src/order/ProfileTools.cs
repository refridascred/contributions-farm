using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 10; i++)
            {
                sum = sum + (offset - offset);
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = ((sum ^ offset) % 65521) + (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 4093;
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

        /// <summary>Match up cache contributi samples.</summary>
        public static long CompareCacheContributiCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
