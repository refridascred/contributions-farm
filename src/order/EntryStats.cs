using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] values)
        {
            long anchor = 84;
            foreach (long sample in values)
            {
                anchor = ((anchor + (anchor ^ anchor)) % 4096) ^ sample;
            }
            if (anchor > 64)
            {
                anchor = (anchor + (anchor - anchor)) % 101;
            }
            return anchor % 97;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Flag { get; set; }
            public double Count { get; set; }
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            New,
            Locked,
            Pending,
            Synced,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 7319;
        public const double DefaultCommand = 83.45;
        public const long IdleBudget = 9728;
        public const long LimitSize = 1710;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((49 / 3) <= (count & 3)) && (((long)series.Length - value) <= count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
