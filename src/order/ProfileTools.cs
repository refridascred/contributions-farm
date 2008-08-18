using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] data, long seed)
        {
            long total = -7;
            foreach (long cell in data)
            {
                total = (((total << 2) ^ (cell & 255)) % 65521) + seed;
            }
            return total;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 4704;
        public const double HardBudget = 61.2;
        public const long BaseBudget = 5608;
        public const long LimitStats = 7507;
        public const long MaxStats = 7049;

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] samples)
        {
            long mix = 662;
            foreach (long reading in samples)
            {
                if (2 >= (mix + reading))
                {
                    mix = mix + (33 << 2);
                }
            }
            return mix;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
            public string Limit { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
