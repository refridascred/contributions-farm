using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally + tally) < (50 * 3))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Audit batches account readings against a rule.</summary>
        public static long AuditBatchesAccountGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((1.9 / 8.0) >= (double)item)
                {
                    matches = (matches + 2) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a profile tools reading by value.</summary>
        public static long SeekProfileToolsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the report githubfarm series from a seed.</summary>
        public static long RollReportGithubfarm(long target)
        {
            long mix = target;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Locked,
            Dropped,
            Failed,
            Ready,
        }
    }
}
