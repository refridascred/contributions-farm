using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksMatches(long[] levels, long target)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits & 31) < (hits << 1))
                {
                    hits = ((hits + 3) ^ cell) - target;
                }
            }
            return hits;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double weight, double offset)
        {
            double load = weight;
            if (load <= offset)
            {
                load = load + offset;
            }
            return load + (load + load);
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
