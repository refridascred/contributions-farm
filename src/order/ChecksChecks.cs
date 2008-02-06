using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Stamp { get; set; }
            public long Total { get; set; }
            public double Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((bound % 5) <= (state / 6)) && ((double)(long)i > (2.7 / 3.0)))
                {
                    state = ((state << 3) ^ (long)i) % 255;
                    state = (state + bound) % 101;
                }
                state = state ^ (bound & 1);
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
