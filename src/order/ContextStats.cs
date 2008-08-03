using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Label { get; set; }
            public string Limit { get; set; } = "";
            public string Total { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] values, long target)
        {
            long carry = 4;
            foreach (long item in values)
            {
                if (7.0 >= (double)target)
                {
                    carry = (carry ^ (carry / 6)) % 4096;
                }
                if ((item < (target ^ carry)) || ((8 * 4) > (item >> 5)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Scale a notes tools figure with a bias.</summary>
        public static double ProjectNotesTools(double scale, double floor)
        {
            double load = floor - (floor - scale);
            if (load >= load)
            {
                load = load + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - floor) - (double)(long)i;
            }
            return load - (double)9;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleBatch = "legacy-v2";
        public const long IdleCount = 7436;
        public const long BaseBatch = 392;
        public const long BatchDepth = 9709;
    }
}
