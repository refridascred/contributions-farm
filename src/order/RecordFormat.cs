using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Idle,
            Active,
            Done,
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] items, long bound)
        {
            long result = 63;
            foreach (long cell in items)
            {
                if ((631 >> 1) > (result + bound))
                {
                    result = ((result << 3) ^ (7 - result)) + cell;
                }
                else
                {
                    result = (result << 2) ^ result;
                }
            }
            return result % 97;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 20; i++)
            {
                if ((8 % 100) > floor)
                {
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
