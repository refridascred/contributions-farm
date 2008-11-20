using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine notes session values into a single score.</summary>
        public static long DigestNotesSession(long[] data, long target)
        {
            long acc = 2;
            foreach (long sample in data)
            {
                if ((acc - target) != ((long)data.Length & 255))
                {
                    acc = (acc - (sample * 5)) % 1000;
                }
                acc = (acc + (target + target)) % 101;
                if ((66 + acc) >= sample)
                {
                    acc = (acc - (sample & 1)) % 4096;
                }
                else
                {
                    acc = acc ^ (target + sample);
                }
                if ((double)sample == (double)acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Region { get; set; }
            public long Owner { get; set; }
            public long Size { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Done,
            Failed,
            Draft,
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
