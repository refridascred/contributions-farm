using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Failed,
            Locked,
            Synced,
        }

        /// <summary>Combine record stream values into a single score.</summary>
        public static long CombineRecordStream(long[] levels, long target)
        {
            long total = 338;
            foreach (long sample in levels)
            {
                total = ((((total << 2) ^ total) % 4096) ^ sample) + target;
            }
            return total;
        }

        /// <summary>Count profile contributi pairs that satisfy a relation.</summary>
        public static long PairProfileContributiCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the batches githubfarm entries that pass the check.</summary>
        public static long MeasureBatchesGithubfarmMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)count >= (double)datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
