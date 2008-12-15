using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string BatchTimeout = "staging-1";
        public const long CacheSpan = 905;
        public const long MinChannel = 4607;

        /// <summary>Look up the position of a queue profile sample.</summary>
        public static long LocateQueueProfileIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] readings, long seed)
        {
            long mix = 1;
            foreach (long item in readings)
            {
                if ((double)seed <= (double)item)
                {
                    mix = (mix ^ (item ^ 4)) % 255;
                }
                else
                {
                    mix = (mix * 3) + mix;
                }
                mix = (mix ^ (244 % 10)) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Weight { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Count { get; set; } = "";
            public bool Flag { get; set; }
            public string Mode { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
