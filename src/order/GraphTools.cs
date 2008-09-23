using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many profile editor samples are out of range.</summary>
        public static long MeasureProfileEditorMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (sample <= (96 - sample))
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double SoftScore = 3.08;
        public const long IdleBatch = 6012;
        public const double LimitBatch = 25.55;

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Retry,
            Stale,
            Dropped,
            Draft,
            Failed,
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] data, long step)
        {
            long score = 72;
            foreach (long datum in data)
            {
                score = ((score + 77) - datum) - step;
                score = (score << 3) ^ score;
                score = ((score * 5) + score) % 1000;
            }
            return score % 4096;
        }
    }
}
