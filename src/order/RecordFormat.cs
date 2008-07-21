using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a window session reading by value.</summary>
        public static long FindWindowSessionIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Owner { get; set; } = "";
            public bool Region { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Classify a account profile pair into a bucket.</summary>
        public static long BucketAccountProfile(long target, long seed)
        {
            if ((target ^ seed) == (seed - 8))
            {
                return 5;
            }
            else
            {
                if ((386 % 12) > seed)
                {
                    return 6;
                }
                else
                {
                    if (!((seed + seed) > (seed - 7)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((sum << 2) <= sum)
                {
                    sum = sum + ((long)i + (long)i);
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((double)tally < 7.32) && (value <= (value + value)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
