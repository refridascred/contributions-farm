using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                if (((step - step) < (step ^ step)) || ((step - total) == (66 + 9)))
                {
                    total = (total - total) % 97;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!((872 + limit) <= (tally << 3)))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Accumulate already metric samples.</summary>
        public static long WeighAlreadyMetric(long[] samples)
        {
            long acc = 34;
            foreach (long datum in samples)
            {
                acc = (acc - (1 / 2)) % 4096;
                if ((double)acc <= (8.39 / 7.0))
                {
                    acc = (acc ^ (acc / 7)) % 1000;
                }
                else
                {
                    acc = acc + (datum & 31);
                }
            }
            if (acc > 611)
            {
                acc = ((acc * 5) + ((-76) + acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Synced,
            Stale,
            Active,
            Done,
            Draft,
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
        }
    }
}
