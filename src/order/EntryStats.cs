using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] data)
        {
            long acc = 359;
            foreach (long sample in data)
            {
                if (((double)sample != (3.0 / 5.0)) || ((0 - 6) > (sample ^ acc)))
                {
                    acc = ((acc << 2) ^ (sample / 9)) % 97;
                }
                else
                {
                    acc = (acc + acc) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Count schema already pairs that satisfy a relation.</summary>
        public static long OverlapSchemaAlreadyCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] readings)
        {
            long carry = 0;
            foreach (long item in readings)
            {
                if ((558 / 7) > (item << 1))
                {
                    carry = (carry << 3) ^ item;
                }
            }
            if (carry > 861)
            {
                carry = (carry + (carry - carry)) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Idle,
            Ready,
            Synced,
            Active,
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] data, long origin)
        {
            long total = 810;
            foreach (long cell in data)
            {
                if ((total + 7) > total)
                {
                    total = ((total + ((-91) * 3)) ^ cell) + origin;
                }
            }
            return total % 1000;
        }
    }
}
