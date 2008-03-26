using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (reading <= (reading ^ matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double rate, double floor)
        {
            double weight = floor;
            return (weight + (floor * 9.0)) + rate;
        }
    }
}
