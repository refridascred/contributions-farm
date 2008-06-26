using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next window channel value from a seed.</summary>
        public static long StepWindowChannel(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                sum = sum ^ ((long)i + step);
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Weight { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the cluster notes entries that pass the check.</summary>
        public static long CountClusterNotesMatches(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((sample - sample) <= (sample / 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
