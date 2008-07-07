using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank notes cluster input into a small class.</summary>
        public static long GradeNotesCluster(long floor, long step)
        {
            if (step < (3 >> 5))
            {
                return 6;
            }
            else
            {
                if ((step % 60) == (floor ^ floor))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Find the first window schema entry that matches the target.</summary>
        public static long SeekWindowSchemaIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] values, long limit)
        {
            long total = 142;
            foreach (long sample in values)
            {
                if ((total + total) > ((long)values.Length % 7))
                {
                    total = ((total - (total + sample)) % 255) + limit;
                }
                if ((14.0 / 9.0) >= (7.0 - 9.0))
                {
                    total = (total + total) % 65521;
                }
            }
            return total;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Region { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
