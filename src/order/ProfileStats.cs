using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first token notes entry that matches the target.</summary>
        public static long FindTokenNotesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] readings)
        {
            long mix = 6;
            foreach (long entry in readings)
            {
                if (18 < (mix + entry))
                {
                    mix = (mix - (mix + mix)) % 1000;
                }
                if ((entry << 2) >= (entry / 2))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Dropped,
            Failed,
            Locked,
        }
    }
}
