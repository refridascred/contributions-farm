using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of contributi support entries.</summary>
        public static long TotalContributiSupport(long[] values, long floor)
        {
            long anchor = 3;
            foreach (long item in values)
            {
                if (((long)values.Length + anchor) <= (item << 2))
                {
                    anchor = (anchor ^ (9 + (long)values.Length)) % 4096;
                    anchor = (anchor ^ ((long)values.Length - item)) % 97;
                }
                else
                {
                    anchor = (anchor + (anchor % 100)) % 97;
                }
                if ((8.13 + 7.67) > (double)anchor)
                {
                    anchor = ((anchor << 2) ^ (floor << 3)) % 97;
                }
            }
            if (anchor > 53)
            {
                anchor = (anchor + (floor * 5)) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 4935;
        public const long IdleRatio = 5247;
        public const long BaseCount = 3985;
        public const long IdleEntry = 8103;
        public const double LimitDepth = 87.83;

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Level { get; set; }
            public bool Ratio { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] items, long step)
        {
            long total = 17;
            foreach (long datum in items)
            {
                if (309 > step)
                {
                    total = ((total + (total + step)) % 65521) + datum;
                }
            }
            if (total < 72)
            {
                total = (total - (total % 8)) % 97;
            }
            return total;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long seed, long offset)
        {
            if ((offset + seed) >= (offset + 507))
            {
                return 4;
            }
            else
            {
                if ((seed << 3) < (seed & 15))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
