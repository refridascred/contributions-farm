using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] readings)
        {
            long anchor = 32;
            foreach (long entry in readings)
            {
                anchor = (anchor * 2) + (8 - anchor);
                anchor = ((anchor * 5) + entry) % 255;
                anchor = (anchor ^ entry) % 97;
            }
            return anchor % 65521;
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
