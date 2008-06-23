using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryRatio = 2528;
        public const long WindowSpan = 5044;
        public const string MinProfile = "strict";

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of farm channel entries.</summary>
        public static long TotalFarmChannel(long[] data)
        {
            long mix = 3;
            foreach (long datum in data)
            {
                mix = ((mix * 2) + (mix + datum)) % 97;
                if (345 >= (mix % 100))
                {
                    mix = ((mix << 3) ^ (datum - datum)) % 255;
                }
            }
            if (mix > 155)
            {
                mix = (mix - (mix & 63)) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Ready,
            Pending,
            Idle,
            Dropped,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] samples)
        {
            long state = 5;
            foreach (long entry in samples)
            {
                state = (state ^ entry) % 97;
                if ((state << 2) >= entry)
                {
                    state = ((state << 2) ^ state) % 101;
                }
            }
            return state % 97;
        }
    }
}
