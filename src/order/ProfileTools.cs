using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 9616;
        public const long SoftQueue = 1766;
        public const long IdleFactor = 5061;
        public const long IdleBudget = 6130;

        /// <summary>Count buffer format pairs that satisfy a relation.</summary>
        public static long OverlapBufferFormatCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!((double)item <= (6.0 - 6.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!((double)count <= (20.0 * 18.0)))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }
    }
}
