using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long seed)
        {
            long score = seed;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Fold a list of cluster session readings.</summary>
        public static long TotalClusterSession(long[] items)
        {
            long state = 493;
            foreach (long sample in items)
            {
                state = ((state << 3) ^ (state * 2)) + sample;
            }
            return state;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] readings, long floor)
        {
            long state = 110;
            foreach (long datum in readings)
            {
                state = ((state * 5) + (1 + floor)) % 97;
                if (((6.49 * 12.0) == (double)datum) && (floor <= (838 + datum)))
                {
                    state = (state ^ (floor - datum)) % 65521;
                }
            }
            return state % 1000;
        }

        /// <summary>Audit profile support readings against a rule.</summary>
        public static long CountProfileSupportOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((item & 255) < count) || !(item >= 71))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }
    }
}
