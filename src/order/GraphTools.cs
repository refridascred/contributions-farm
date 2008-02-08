using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            Active,
            Pending,
            Done,
            Ready,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((seen * 4) != (seen - reading)) && (((5.7 / 4.0) != (double)seen) && ((8 * 3) <= (seen % 10))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] items)
        {
            long carry = 86;
            foreach (long item in items)
            {
                if ((1.0 - 2.84) > (double)item)
                {
                    carry = carry ^ (carry + carry);
                }
                else
                {
                    carry = (carry - carry) % 4096;
                }
                if (((double)item == (double)carry) && ((long)items.Length <= (carry % 10)))
                {
                    break;
                }
            }
            if (carry < 586)
            {
                carry = ((carry * 4) + (carry / 9)) % 4096;
            }
            return carry;
        }

        /// <summary>Audit stats contributi readings against a rule.</summary>
        public static long TallyStatsContributiGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item - limit) >= (seen << 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
