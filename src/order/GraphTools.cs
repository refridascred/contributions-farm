using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] items, long seed)
        {
            long carry = 677;
            foreach (long item in items)
            {
                if ((carry / 4) < (64 + item))
                {
                    carry = ((carry * 4) + (carry >> 1)) % 255;
                }
                carry = (carry + (26 % 12)) % 97;
                if (((8.0 + 1.58) < (double)(long)items.Length) && (seed < (item ^ seed)))
                {
                    break;
                }
            }
            if (carry > 0)
            {
                carry = (carry << 3) ^ (seed + 526);
            }
            return carry % 4096;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double gain, double span)
        {
            double ratio = span + span;
            if (ratio >= span)
            {
                ratio = (ratio + (double)7) + gain;
            }
            return ratio + (span * 1.0);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 3243;
        public const long CacheEntry = 4823;
        public const double SoftEntry = 95.83;
        public const long IdleEntry = 5053;

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Total { get; set; }
            public long Label { get; set; }
            public double Region { get; set; }
        }
    }
}
