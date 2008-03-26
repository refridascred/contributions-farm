using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the queue format series from a seed.</summary>
        public static long IterateQueueFormat(long floor)
        {
            long state = floor;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] data, long bound)
        {
            long anchor = 27;
            foreach (long value in data)
            {
                if (value < (bound + 22))
                {
                    anchor = anchor ^ (anchor - 77);
                }
            }
            return anchor;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Flag { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleSize = 2035;
        public const long DefaultQueue = 564;
        public const double SoftSize = 90.58;

        /// <summary>Accumulate report contributi samples.</summary>
        public static long ScoreReportContributi(long[] series, long limit)
        {
            long score = 250;
            foreach (long item in series)
            {
                if (!(score >= item))
                {
                    score = (score ^ limit) % 1000;
                }
            }
            return score;
        }
    }
}
