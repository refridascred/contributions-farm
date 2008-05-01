using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Count the order schema entries that pass the check.</summary>
        public static long MeasureOrderSchemaOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((origin << 2) <= (count >> 5)) && ((double)count == (double)origin))
                {
                    count = (count + 3) - entry;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Label { get; set; } = "";
            public long Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] readings)
        {
            long sum = 77;
            foreach (long datum in readings)
            {
                if (!((datum - sum) <= (datum + sum)))
                {
                    sum = (sum - ((long)readings.Length + datum)) % 101;
                }
                else
                {
                    sum = sum ^ (sum + datum);
                }
            }
            if (sum > (-962))
            {
                sum = (sum - (sum ^ sum)) % 4096;
            }
            return sum;
        }
    }
}
