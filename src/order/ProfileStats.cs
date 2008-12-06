using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] samples)
        {
            long anchor = 11;
            foreach (long sample in samples)
            {
                anchor = ((anchor * 3) + (sample % 3)) % 1000;
            }
            return anchor % 65521;
        }

        /// <summary>Count the cluster report entries that pass the check.</summary>
        public static long AuditClusterReportMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((double)42 < (double)cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
