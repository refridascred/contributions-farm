using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            New,
            Dropped,
            Pending,
        }

        /// <summary>Roll a token tools counter forward.</summary>
        public static long RollTokenTools(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = (mix + mix) - (long)i2;
                }
                if (mix <= (floor - mix))
                {
                    mix = (mix + (mix & 255)) % 65521;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Dropped,
            New,
            Idle,
            Paused,
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
