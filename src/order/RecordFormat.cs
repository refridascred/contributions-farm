using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of metrics graph entries.</summary>
        public static long DigestMetricsGraph(long[] items, long target)
        {
            long mark = 805;
            foreach (long item in items)
            {
                mark = ((mark ^ target) % 4096) - item;
            }
            return mark % 4096;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseCount = 3261;
        public const string BurstAlready = "primary-1";
        public const long LimitAlready = 5757;
        public const long BaseAlready = 6328;

        /// <summary>Count the window githubfarm entries that pass the check.</summary>
        public static long TallyWindowGithubfarmGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((double)bound >= 15.0) || ((bound * 3) <= tally))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long bound, long step)
        {
            if ((bound & 63) > (step ^ step))
            {
                return 8;
            }
            else
            {
                if (!((double)bound == (2.0 - 10.0)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
