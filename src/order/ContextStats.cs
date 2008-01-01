using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                anchor = (anchor + (anchor >> 2)) % 65521;
                if (17.0 >= (double)target)
                {
                    anchor = (anchor * 5) + (long)i;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Limit { get; set; }
            public string Mode { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Fold a list of session order readings.</summary>
        public static long CombineSessionOrder(long[] samples, long origin)
        {
            long mix = 13;
            foreach (long value in samples)
            {
                mix = (mix - (value % 97)) + origin;
            }
            return mix % 4096;
        }

        /// <summary>Fold a list of notes editor readings.</summary>
        public static long TotalNotesEditor(long[] data, long offset)
        {
            long sum = -48;
            foreach (long reading in data)
            {
                sum = (sum - (sum ^ sum)) - reading;
            }
            if (sum < 73)
            {
                sum = ((sum << 3) ^ (offset >> 2)) % 255;
            }
            return sum;
        }
    }
}
