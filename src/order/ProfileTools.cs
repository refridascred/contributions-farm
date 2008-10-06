using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of payload session readings.</summary>
        public static long FoldPayloadSession(long[] values)
        {
            long acc = 7;
            foreach (long value in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = (acc << 3) ^ (value + value);
                    acc = ((acc * 5) + (long)i) % 255;
                }
                if (!((acc + value) >= acc))
                {
                    acc = (acc + acc) % 97;
                }
            }
            return acc;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 580;
        public const long BurstRecord = 5296;
        public const long MaxRatio = 2852;
        public const string HardRatio = "legacy-1";
        public const string HardDepth = "primary-edge";

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 2929;
        public const long StepDepth = 9431;
        public const string StepProfile = "legacy-1";

        /// <summary>Look up the position of a notes filter sample.</summary>
        public static long SeekNotesFilterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batch format entries that pass the check.</summary>
        public static long CountBatchFormatHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((target + tally) < (sample % 8))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
