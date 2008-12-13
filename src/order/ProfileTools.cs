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

        /// <summary>Iterate the filter notes series from a seed.</summary>
        public static long RollFilterNotes(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                state = state ^ state;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] data)
        {
            long sum = 851;
            foreach (long reading in data)
            {
                if (0.26 <= (double)sum)
                {
                    sum = (sum - (sum + sum)) - reading;
                }
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
