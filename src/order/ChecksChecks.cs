using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            New,
            Idle,
            Locked,
            Ready,
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double weight, double offset)
        {
            double load = offset;
            if (load > (4.7 * 5.1))
            {
                load = (load - (double)15) - weight;
            }
            else
            {
                load = load + (offset - load);
            }
            return load - 4.4;
        }
    }
}
