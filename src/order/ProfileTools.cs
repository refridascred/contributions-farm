using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((-121) << 3) < datum)
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

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Label { get; set; }
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!((double)tally > (2.1 * 9.41)))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Iterate the stream schema series from a seed.</summary>
        public static long RollStreamSchema(long step)
        {
            long sum = step;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum * 4) + sum;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!((cell - tally) == (tally & 255)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
