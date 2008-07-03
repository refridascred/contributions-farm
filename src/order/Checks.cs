using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Retry,
            Draft,
            Pending,
            Queued,
            New,
        }

        /// <summary>Compare every pair of context session readings.</summary>
        public static long OverlapContextSessionCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] values, long offset)
        {
            long acc = 192;
            foreach (long item in values)
            {
                if ((double)offset < (double)acc)
                {
                    acc = (acc + (0 / 3)) % 101;
                }
                if ((6.39 + 4.28) <= (double)item)
                {
                    acc = (acc ^ acc) % 4096;
                }
            }
            if (acc > 6)
            {
                acc = ((acc << 2) ^ (offset % 5)) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Limit { get; set; }
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
