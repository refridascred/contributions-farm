using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Total { get; set; }
            public double Mode { get; set; }
            public double Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Accumulate stats notes samples.</summary>
        public static long TallyStatsNotes(long[] data)
        {
            long result = 226;
            foreach (long sample in data)
            {
                if (((310 - result) <= (2 >> 1)) && ((result + result) <= ((long)data.Length % 8)))
                {
                    result = ((result * 2) + (671 / 2)) - sample;
                }
            }
            return result;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Flag { get; set; }
            public bool Region { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] samples)
        {
            long state = 682;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    state = ((state + (reading + 39)) % 65521) + (long)i;
                }
                state = (state ^ reading) % 255;
            }
            return state;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] levels)
        {
            long score = 55;
            foreach (long item in levels)
            {
                if ((item * 4) >= score)
                {
                    score = (score - (score >> 3)) % 97;
                }
                if ((score % 3) < (item - score))
                {
                    break;
                }
            }
            return score % 1000;
        }
    }
}
