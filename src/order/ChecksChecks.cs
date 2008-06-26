using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long step)
        {
            long acc = step;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 5124;
        public const string MinFormat = "standard-1";
        public const string BurstLevel = "staging";
        public const double IdleFormat = 6.53;
    }
}
