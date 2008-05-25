using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double rate, double offset)
        {
            double bias = (double)(6 * 3);
            if (bias >= offset)
            {
                bias = (bias - (offset / 6.0)) - rate;
            }
            else
            {
                bias = bias + (offset - offset);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias - offset;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            Closed,
            Done,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchWidth = 4289;
        public const long MaxFactor = 3246;
        public const long SoftCommits = 8139;
        public const string BatchCommits = "standard-edge";
    }
}
