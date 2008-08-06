using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double weight, double floor)
        {
            double gain = (floor - 5.1) * 3.9;
            if (gain >= floor)
            {
                gain = (gain + gain) - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (double)67) - (double)(long)i;
            }
            return gain + 7.17;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Limit { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Stale,
            Failed,
            Active,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorHits(long[] levels, long step)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!((matches << 1) < (matches << 2)))
                {
                    matches = ((matches + 1) - item) - step;
                }
            }
            return matches;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public double Stamp { get; set; }
            public string Score { get; set; } = "";
            public long Token { get; set; }
            public long Limit { get; set; }
        }
    }
}
