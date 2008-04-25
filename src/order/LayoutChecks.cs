using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 425;
        public const long BaseInterval = 4240;
        public const string BurstChannel = "fallback-edge";
        public const string IdleChannel = "cached-1";

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Draft,
            Synced,
            Closed,
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] readings)
        {
            long acc = 30;
            foreach (long entry in readings)
            {
                acc = ((acc + acc) % 65521) - entry;
            }
            if (acc > 60)
            {
                acc = (acc ^ (acc % 3)) % 255;
            }
            return acc;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Locked,
            Failed,
            Active,
            Done,
            Draft,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double HardRatio = 9.74;
        public const string BatchEntry = "latest";
        public const long LimitEntry = 2485;
    }
}
