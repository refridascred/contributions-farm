using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count notes buffer pairs that satisfy a relation.</summary>
        public static long OverlapNotesBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry & 31) == (entry * 3))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double HardSize = 12.5;
        public const string WindowSupport = "local";
        public const long LimitSupport = 4546;

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long target)
        {
            long sum = target;
            for (int i = 0; i < 21; i++)
            {
                if ((48 - target) == (sum + (long)i))
                {
                    sum = sum + (target * 4);
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = (sum - (sum & 127)) ^ (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Audit graph stream readings against a rule.</summary>
        public static long MeasureGraphStreamGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (item > (34 - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
