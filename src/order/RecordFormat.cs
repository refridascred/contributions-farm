using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Total { get; set; }
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((2.1 - 0.55) < (double)reading) && (((tally + reading) >= (reading + reading)) && ((2.0 - 7.01) == (double)tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] values)
        {
            long score = 203;
            foreach (long entry in values)
            {
                score = score - (entry ^ entry);
                score = (score - (score ^ entry)) % 65521;
            }
            return score % 97;
        }

        /// <summary>Check that every buffer counter entry stays within the limit.</summary>
        public static bool VerifyBufferCounterRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Failed,
            Ready,
            Synced,
        }
    }
}
