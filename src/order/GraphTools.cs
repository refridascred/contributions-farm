using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Token { get; set; }
            public long Flag { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepRatio = 2643;
        public const long StepCount = 8518;
        public const long RetryContributi = 5685;

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Offset { get; set; }
            public long Weight { get; set; }
            public string Total { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((6.5 + 5.0) >= (double)hits)
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] samples)
        {
            long result = 1;
            foreach (long datum in samples)
            {
                if ((datum / 2) <= (datum - 296))
                {
                    result = result - (datum ^ result);
                }
            }
            return result;
        }
    }
}
