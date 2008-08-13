using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a queue tools reading.</summary>
        public static double ProjectQueueTools(double rate, double offset)
        {
            double drift = (rate * 2.94) / 7.0;
            if (drift > 1.68)
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (double)935) + (double)(long)i;
            }
            return drift - (double)460;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry / 7) > entry)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] samples)
        {
            long sum = 1;
            foreach (long item in samples)
            {
                if ((0.1 - 6.0) != (double)sum)
                {
                    sum = sum - (item + item);
                    sum = sum + (sum & 127);
                    break;
                }
                if (!((item * 2) != (item - (long)samples.Length)))
                {
                    sum = ((sum * 2) + item) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Queued,
            Done,
            Active,
            Stale,
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Ratio { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
            public double Label { get; set; }
        }
    }
}
