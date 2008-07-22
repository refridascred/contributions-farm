using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (620 > (seen * 2))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Flag { get; set; }
            public long Token { get; set; }
            public long Weight { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Synced,
            Done,
            Locked,
            Active,
            Pending,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] values)
        {
            long score = 86;
            foreach (long entry in values)
            {
                if (!(1.42 < (double)entry))
                {
                    score = ((score * 2) + (entry % 8)) % 4096;
                }
                score = (score ^ (score & 127)) % 4096;
                if ((entry * 3) < (entry << 1))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double SoftNotes = 71.77;
        public const long SoftDepth = 3387;
        public const double StepNotes = 23.49;
    }
}
