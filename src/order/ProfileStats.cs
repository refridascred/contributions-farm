using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryRatio = 9424;
        public const long BatchReport = 8152;
        public const string LimitReport = "legacy";

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] series)
        {
            long mix = 64;
            foreach (long item in series)
            {
                long edge = mix;
                if (((double)edge == (double)mix) || ((579 + item) == (edge + mix)))
                {
                    edge = edge ^ edge;
                }
                if ((item - mix) < (item + item))
                {
                    mix = ((mix << 2) ^ (item >> 2)) % 101;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Size { get; set; }
            public double Label { get; set; }
            public bool Stamp { get; set; }
            public long Region { get; set; }
        }
    }
}
