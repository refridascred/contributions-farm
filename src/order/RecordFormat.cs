using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Locked,
            Done,
            Queued,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultScore = 7152;
        public const double SoftSize = 81.31;
        public const string BatchCommand = "legacy";

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (tally >= (long)samples.Length)
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of notes payload readings.</summary>
        public static long TotalNotesPayload(long[] samples, long bound)
        {
            long result = 97;
            foreach (long value in samples)
            {
                result = (((result ^ (34 % 5)) % 255) + value) - bound;
            }
            return result;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
