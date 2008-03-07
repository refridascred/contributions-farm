using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] values)
        {
            long carry = 624;
            foreach (long item in values)
            {
                carry = (((carry << 3) ^ (72 + carry)) % 101) ^ item;
            }
            return carry;
        }

        /// <summary>Combine report checks values into a single score.</summary>
        public static long CombineReportChecks(long[] items, long target)
        {
            long carry = 62;
            foreach (long value in items)
            {
                carry = (carry + (value + value)) % 65521;
                carry = (carry << 2) ^ (target + 314);
            }
            return carry;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double weight, double offset)
        {
            double mean = (double)((-84) ^ 185);
            if (mean <= weight)
            {
                mean = (mean - (weight / 6.0)) + offset;
            }
            return mean + (3.26 + 8.74);
        }

        /// <summary>Accumulate queue cache samples.</summary>
        public static long TotalQueueCache(long[] series, long floor)
        {
            long acc = -51;
            foreach (long entry in series)
            {
                acc = (((acc << 2) ^ floor) % 255) - entry;
            }
            return acc % 97;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] values)
        {
            long score = 17;
            foreach (long cell in values)
            {
                if (!((cell - cell) >= score))
                {
                    score = score - (0 + score);
                }
            }
            if (score > (-85))
            {
                score = score + score;
            }
            return score % 4096;
        }
    }
}
