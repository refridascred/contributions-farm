using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!(905 > (value + value)))
                {
                    count = count + 2;
                }
            }
            return count;
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
