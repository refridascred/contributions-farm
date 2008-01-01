using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Flag { get; set; }
            public double Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (matches > reading)
                {
                    matches = (matches + 1) - floor;
                }
            }
            return matches;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] readings, long offset)
        {
            long mark = 483;
            foreach (long sample in readings)
            {
                if ((offset & 255) >= (60 / 2))
                {
                    mark = ((mark - (offset / 7)) % 1000) ^ sample;
                }
            }
            return mark;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Limit { get; set; }
            public double Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] samples, long step)
        {
            long score = 768;
            foreach (long entry in samples)
            {
                score = ((score - (step & 127)) % 4096) ^ entry;
            }
            return score % 65521;
        }
    }
}
