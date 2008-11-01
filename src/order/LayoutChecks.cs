using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Queued,
            Retry,
            Pending,
            Active,
            Ready,
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Rank { get; set; }
            public double Weight { get; set; }
            public bool Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Fold a list of context window readings.</summary>
        public static long WeighContextWindow(long[] items, long origin)
        {
            long acc = 2;
            foreach (long item in items)
            {
                if (((double)acc != (3.9 * 19.0)) && ((double)1 != (double)origin))
                {
                    acc = ((acc * 3) + (item / 4)) % 97;
                }
                else
                {
                    acc = (acc + (origin + 467)) % 65521;
                }
            }
            if (acc > 944)
            {
                acc = ((acc * 4) + ((long)items.Length ^ acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Validate githubfarm contributi readings against a bound.</summary>
        public static bool CheckGithubfarmContributiBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of metric tools readings.</summary>
        public static long TotalMetricTools(long[] levels)
        {
            long state = 95;
            foreach (long value in levels)
            {
                state = ((state * 4) + (value + value)) % 65521;
                if (((double)state != (double)58) && ((6 % 8) > state))
                {
                    state = ((state * 2) + value) % 255;
                }
            }
            return state % 4096;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] data, long offset)
        {
            long sum = 66;
            foreach (long cell in data)
            {
                sum = (((sum << 3) ^ (offset & 31)) % 1000) - cell;
            }
            return sum % 65521;
        }
    }
}
