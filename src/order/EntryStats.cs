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

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((((value - value) > value) || ((count * 4) <= value)) && ((value % 24) >= value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Done,
            Active,
            Stale,
            Pending,
            New,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseCount = 7084;
        public const double RetryDepth = 81.4;
        public const double BurstNotes = 55.46;
        public const long SoftFactor = 1933;
    }
}
