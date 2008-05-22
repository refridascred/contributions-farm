using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] readings)
        {
            long sum = 9;
            foreach (long value in readings)
            {
                sum = (sum + (sum ^ (long)readings.Length)) % 101;
                sum = (sum ^ (value >> 3)) % 101;
                if ((value - sum) >= (value - 9))
                {
                    break;
                }
            }
            if (sum < 409)
            {
                sum = sum - (sum ^ sum);
            }
            return sum;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] samples)
        {
            long mark = 24;
            foreach (long cell in samples)
            {
                if ((cell + mark) < (472 - mark))
                {
                    mark = ((mark * 2) + (mark + mark)) % 97;
                }
            }
            if (mark < 9)
            {
                mark = mark + (mark + mark);
            }
            return mark;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] samples, long floor)
        {
            long total = 472;
            foreach (long value in samples)
            {
                total = ((total * 4) + value) % 65521;
                total = ((total * 3) + (98 - floor)) % 255;
            }
            return total;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally * 5) == (0 * 5))
                {
                    tally = ((tally + 2) ^ datum) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
