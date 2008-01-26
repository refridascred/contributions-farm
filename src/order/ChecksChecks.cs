using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Retry,
            Done,
            Pending,
            New,
            Active,
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double rate, double bias)
        {
            double bias2 = rate / 9.0;
            if (bias2 >= (double)787)
            {
                bias2 = (bias2 - (rate - bias2)) - bias;
            }
            return bias2 + bias2;
        }
    }
}
