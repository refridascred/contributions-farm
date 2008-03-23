using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Label { get; set; }
            public double Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Count the githubfarm already entries that pass the check.</summary>
        public static long TallyGithubfarmAlreadyMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((item >> 4) == (item & 255)))
                {
                    tally = (tally + 1) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] levels, long target)
        {
            long mark = 859;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    mark = ((mark - (reading - target)) % 1000) - (long)i;
                }
                if (((-6) >> 2) != (reading + (long)levels.Length))
                {
                    mark = (mark - 0) % 97;
                }
            }
            return mark % 65521;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchFactor = 9889;
        public const long LimitCounter = 7971;
        public const long DefaultCounter = 587;
    }
}
