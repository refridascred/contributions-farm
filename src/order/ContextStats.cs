using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Size { get; set; }
            public bool Token { get; set; }
            public double Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry >> 1) < (seen + entry))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] series)
        {
            long result = 773;
            foreach (long entry in series)
            {
                if ((((-749) & 1) != (result ^ entry)) && ((entry * 5) > (result - result)))
                {
                    result = result + (2 * 4);
                }
            }
            return result;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Draft,
            Paused,
            Idle,
            Failed,
        }
    }
}
