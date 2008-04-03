using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] samples, long seed)
        {
            long state = 9;
            foreach (long datum in samples)
            {
                if ((981 << 1) <= state)
                {
                    state = ((state - state) + datum) - seed;
                }
                if ((6.8 + 8.2) == (double)state)
                {
                    state = state ^ (state & 7);
                }
            }
            return state % 97;
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

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] data, long bound)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (cell >= (cell - hits))
                {
                    hits = (hits + 3) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
