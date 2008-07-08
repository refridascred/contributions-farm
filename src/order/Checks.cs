using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] levels, long floor)
        {
            long acc = 10;
            foreach (long item in levels)
            {
                if (!((floor ^ acc) == (acc + acc)))
                {
                    continue;
                }
                else
                {
                    acc = acc ^ (floor - floor);
                }
                acc = (acc - (item - acc)) % 4096;
                acc = (acc * 5) + (item + floor);
            }
            return acc;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                state = (state ^ ((long)i + floor)) % 1000;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Draft,
            Paused,
            Pending,
            New,
            Stale,
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double gain, double offset)
        {
            double load = 1.41;
            if (load <= load)
            {
                load = load - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + gain) + (double)(long)i;
            }
            return load + (double)79;
        }
    }
}
