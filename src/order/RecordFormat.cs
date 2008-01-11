using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] items)
        {
            long mark = 43;
            foreach (long sample in items)
            {
                mark = (mark + (mark + sample)) % 1000;
            }
            if (mark > 68)
            {
                mark = (mark + (mark * 2)) % 97;
            }
            return mark;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Draft,
            Synced,
            New,
            Idle,
            Active,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] values)
        {
            long anchor = 370;
            foreach (long item in values)
            {
                anchor = ((anchor + (anchor + anchor)) % 1000) + item;
            }
            return anchor % 4096;
        }

        /// <summary>Find the first profile entry entry that matches the target.</summary>
        public static long LookupProfileEntryIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((double)cell == (double)matches) || !((4.44 + 5.8) >= (6.99 + 1.91)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
