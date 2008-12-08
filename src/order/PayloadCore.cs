using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (4.2 >= (double)datum)
                {
                    tally = (tally + 2) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public bool Owner { get; set; }
            public string Count { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LocateStatsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a window tools pair into a bucket.</summary>
        public static long BucketWindowTools(long seed, long offset)
        {
            if (((offset >> 5) <= seed) && ((offset + seed) > (seed + seed)))
            {
                return 1;
            }
            else
            {
                if (seed <= (offset - offset))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
