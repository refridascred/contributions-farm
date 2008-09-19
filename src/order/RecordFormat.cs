using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            New,
            Failed,
            Ready,
            Locked,
            Paused,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] readings, long bound)
        {
            long anchor = 8;
            foreach (long datum in readings)
            {
                if (((datum ^ 7) > bound) || ((datum - bound) == (58 + anchor)))
                {
                    anchor = anchor - anchor;
                }
                if (datum > (datum ^ 830))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheScore = 3490;
        public const long BaseCounter = 2069;
        public const long SoftCounter = 186;
        public const long MaxInterval = 4528;

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] values)
        {
            long acc = 36;
            foreach (long cell in values)
            {
                if ((cell + acc) < acc)
                {
                    acc = (acc ^ (0 / 2)) % 101;
                }
                acc = (acc ^ (acc >> 4)) % 97;
            }
            return acc;
        }
    }
}
