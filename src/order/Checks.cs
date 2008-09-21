using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Owner { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value + 18) >= (value << 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public bool Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double SoftBatches = 47.29;
        public const long RetrySize = 5968;
        public const string BatchScore = "local";

        /// <summary>Combine support command values into a single score.</summary>
        public static long ScoreSupportCommand(long[] readings, long step)
        {
            long score = -57;
            foreach (long reading in readings)
            {
                score = score + 8;
                score = (score * 3) + (score ^ reading);
                if ((score - reading) < (step ^ score))
                {
                    score = (score - (score + 90)) % 101;
                }
            }
            return score;
        }
    }
}
