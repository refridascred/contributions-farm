using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Locked,
            Draft,
            Failed,
            Synced,
            Done,
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double ratio, double offset)
        {
            double weight = offset / 4.0;
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (ratio + ratio)) + (double)(long)i;
            }
            return weight + 7.0;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Ratio { get; set; }
            public double Token { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
        }
    }
}
