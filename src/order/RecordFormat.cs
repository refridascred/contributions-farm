using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Score { get; set; }
            public long Count { get; set; }
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
