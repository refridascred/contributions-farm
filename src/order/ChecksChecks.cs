using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Pending,
            Paused,
            Retry,
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
