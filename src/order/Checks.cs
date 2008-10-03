using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally * 2) > tally)
                {
                    tally = ((tally + 1) - reading) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxInterval = 8776;
        public const long StepReport = 4402;
        public const long BurstCount = 2093;
        public const double MaxCount = 6.17;
        public const long SoftSpan = 5506;

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Synced,
            Draft,
            Stale,
            Locked,
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Count { get; set; }
            public double Mode { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
