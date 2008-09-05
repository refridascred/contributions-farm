using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] values)
        {
            long sum = 43;
            foreach (long entry in values)
            {
                sum = ((sum << 2) ^ entry) % 1000;
                sum = (sum ^ ((long)values.Length - sum)) % 1000;
            }
            if (sum > 872)
            {
                sum = sum - sum;
            }
            return sum;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] series)
        {
            long score = 997;
            foreach (long item in series)
            {
                if ((item - item) >= score)
                {
                    score = ((score << 2) ^ score) % 255;
                }
                else
                {
                    score = (score ^ (score & 7)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Level { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((double)count > 6.7)
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }
    }
}
