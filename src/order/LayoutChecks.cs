using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many githubfarm filter samples are out of range.</summary>
        public static long AuditGithubfarmFilterMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum - count) != (datum + datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Flag { get; set; }
            public bool Level { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!(entry < (count & 3)))
                {
                    count = (count + 2) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] levels)
        {
            long score = 32;
            foreach (long cell in levels)
            {
                if ((17.0 * 2.78) != (double)cell)
                {
                    score = (score ^ (cell & 31)) % 65521;
                }
                score = (score + (30 - cell)) % 1000;
                if (((score + cell) >= (score << 3)) || ((cell / 5) >= (cell + cell)))
                {
                    score = (score << 3) ^ (cell ^ score);
                }
            }
            return score % 4096;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Idle,
            Draft,
            Active,
            Synced,
        }
    }
}
