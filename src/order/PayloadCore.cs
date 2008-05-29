using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheSpan = 3473;
        public const long DefaultSpan = 1088;
        public const long MaxDepth = 7432;
        public const long BaseScore = 1963;

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Mode { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Look up the position of a channel notes sample.</summary>
        public static long SeekChannelNotesIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
