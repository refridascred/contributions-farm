using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long OverlapPayloadCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxFactor = "cached-v2";
        public const string MinDepth = "staging-1";
        public const long SoftChecks = 3006;

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long seed)
        {
            long state = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((4.56 < (double)seed) || ((double)state == (4.0 / 8.0)))
                {
                    state = state ^ state;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!(item < tally))
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Rank { get; set; }
            public bool Region { get; set; }
            public double Total { get; set; }
            public bool Size { get; set; }
        }
    }
}
