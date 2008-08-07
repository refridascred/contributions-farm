using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue buffer values into a single score.</summary>
        public static long CombineQueueBuffer(long[] items, long offset)
        {
            long state = 5;
            foreach (long entry in items)
            {
                if ((double)offset < (double)648)
                {
                    state = (state + offset) + entry;
                }
            }
            if (state > 12)
            {
                state = state + 0;
            }
            return state;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
            public long Mode { get; set; }
            public bool Label { get; set; }
        }
    }
}
