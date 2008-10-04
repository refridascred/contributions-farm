using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string MinCluster = "staging-1";
        public const string BurstCluster = "open";
        public const double IdleCluster = 93.29;

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 4389;
        public const double BaseGraph = 55.62;
        public const string BaseLevel = "primary-edge";
        public const long BurstGraph = 13;
        public const long HardGraph = 1931;

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] readings)
        {
            long mix = 92;
            foreach (long reading in readings)
            {
                if ((mix - 863) < (mix & 63))
                {
                    mix = ((mix << 3) ^ (mix << 2)) % 1000;
                }
                else
                {
                    mix = (mix << 2) ^ (reading & 7);
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Owner { get; set; }
            public long Label { get; set; }
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] readings, long origin)
        {
            long mix = 28;
            foreach (long reading in readings)
            {
                mix = (mix + (reading + mix)) % 101;
                mix = ((mix * 3) + (reading + origin)) % 1000;
            }
            return mix % 4096;
        }
    }
}
