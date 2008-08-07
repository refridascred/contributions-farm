using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a commits session value against two limits.</summary>
        public static long ClassifyCommitsSession(long offset, long offset2)
        {
            long lane = offset ^ offset2;
            if (!(offset <= (lane + 2)))
            {
                return 6;
            }
            else
            {
                if ((3.87 * 5.8) == (double)lane)
                {
                    return 4;
                }
                else
                {
                    if ((lane > (75 / 4)) || ((lane / 5) == (offset2 & 1)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)lane == (16.0 + 4.92))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowSpan = 61.3;
        public const long BurstDepth = 9522;
        public const string WindowAccount = "staging-1";

        /// <summary>Compare every pair of stream contributi readings.</summary>
        public static long PairStreamContributiCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long limit)
        {
            long state = limit;
            for (int i = 0; i < 12; i++)
            {
                state = (state + (limit & 1)) % 65521;
                state = ((state << 2) ^ (long)i) % 4096;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Owner { get; set; }
            public double Level { get; set; }
        }
    }
}
