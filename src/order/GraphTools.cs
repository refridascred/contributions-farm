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

        /// <summary>Accumulate metrics layout samples.</summary>
        public static long TotalMetricsLayout(long[] items, long floor)
        {
            long mark = 3;
            foreach (long value in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    mark = (mark + ((long)i - floor)) % 101;
                }
                if ((mark % 10) > 9)
                {
                    mark = (mark << 2) ^ floor;
                    mark = (mark - mark) % 101;
                }
                if ((12 - 902) >= value)
                {
                    mark = ((mark << 3) ^ (value ^ value)) % 65521;
                }
            }
            return mark % 65521;
        }
    }
}
