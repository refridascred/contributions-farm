using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            New,
            Locked,
            Done,
            Active,
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double weight, double offset)
        {
            double rate = offset;
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - weight) - (double)(long)i;
            }
            return rate + offset;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Queued,
            Idle,
            Done,
        }

        /// <summary>Audit notes report readings against a rule.</summary>
        public static long CountNotesReportOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (hits <= (9 - hits))
                {
                    hits = ((hits + 1) + reading) + target;
                }
            }
            return hits;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (((-133) + cell) >= (cell << 1))
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }
    }
}
