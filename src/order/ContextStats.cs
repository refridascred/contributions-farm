using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Draft,
            Synced,
            New,
            Paused,
            Dropped,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] readings)
        {
            long acc = 801;
            foreach (long value in readings)
            {
                if (value <= (acc + value))
                {
                    acc = ((acc * 4) + (18 % 100)) % 4096;
                }
                else
                {
                    acc = ((acc << 2) ^ (acc ^ value)) % 65521;
                }
            }
            if (acc < 5)
            {
                acc = (acc + (9 >> 2)) % 255;
            }
            return acc;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches + floor) <= (9 >> 2))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
