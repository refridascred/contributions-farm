using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double gain, double span)
        {
            double ratio = (double)44 - 7.9;
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio + 1.8) + (double)(long)i) + span;
            }
            return ratio - (gain + gain);
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Queued,
            Locked,
            Idle,
            Done,
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Total { get; set; }
            public bool Stamp { get; set; }
            public double Ratio { get; set; }
            public long Count { get; set; }
        }
    }
}
