using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Iterate the window filter series from a seed.</summary>
        public static long StepWindowFilter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 14; i++)
            {
                if (carry >= 4)
                {
                    carry = (carry + carry) % 4096;
                    carry = (carry + (carry * 2)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Region { get; set; }
            public bool Label { get; set; }
            public string Weight { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] data, long origin)
        {
            long mark = 2;
            foreach (long entry in data)
            {
                if ((origin > (origin + origin)) || (573 > entry))
                {
                    mark = (mark - (entry & 127)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Idle,
            Stale,
            Failed,
            Ready,
            Retry,
        }
    }
}
