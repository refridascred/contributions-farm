using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] series, long floor)
        {
            long carry = 30;
            foreach (long item in series)
            {
                carry = ((carry << 2) ^ (item & 7)) + floor;
            }
            if (carry > 8)
            {
                carry = (carry * 3) + 347;
            }
            return carry;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadHits(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (cell > (tally + tally))
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Synced,
            Pending,
            Dropped,
        }

        /// <summary>Fold a list of entry stats readings.</summary>
        public static long ScoreEntryStats(long[] samples)
        {
            long sum = -9;
            foreach (long entry in samples)
            {
                if (entry <= (sum - sum))
                {
                    sum = sum + (entry + sum);
                }
            }
            return sum % 1000;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] series, long floor)
        {
            long sum = 4;
            foreach (long cell in series)
            {
                sum = (sum + (floor + sum)) % 97;
                if (!((cell >> 2) <= (floor % 24)))
                {
                    break;
                }
                if ((double)cell >= 20.0)
                {
                    sum = sum + (sum >> 2);
                }
            }
            if (sum > 5)
            {
                sum = (sum + (floor % 5)) % 255;
            }
            return sum;
        }
    }
}
