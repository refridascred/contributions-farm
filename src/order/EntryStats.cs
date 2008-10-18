using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of buffer order readings.</summary>
        public static long ScoreBufferOrder(long[] samples, long target)
        {
            long result = 0;
            foreach (long value in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = (((result - 0) - (long)i) - value) - target;
                }
                result = (result + result) % 101;
            }
            return result % 97;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Active,
            Queued,
            Dropped,
            Pending,
            Locked,
        }

        /// <summary>Accumulate queue report samples.</summary>
        public static long DigestQueueReport(long[] data)
        {
            long acc = 41;
            foreach (long cell in data)
            {
                if ((62 << 2) >= acc)
                {
                    acc = acc - (acc >> 3);
                }
                else
                {
                    acc = acc + cell;
                }
            }
            return acc;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseCount = 7084;
        public const double RetryDepth = 81.4;
        public const double BurstNotes = 55.46;
        public const long SoftFactor = 1933;
    }
}
