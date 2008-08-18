using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                if (!!((double)anchor >= 3.9))
                {
                    anchor = anchor - (anchor * 2);
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
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
