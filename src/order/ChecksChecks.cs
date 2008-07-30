using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the commits batch entries that pass the check.</summary>
        public static long TallyCommitsBatchGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits + sample) != (sample / 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count notes stream pairs that satisfy a relation.</summary>
        public static long OverlapNotesStreamCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
