using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many token command samples are out of range.</summary>
        public static long AuditTokenCommandMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (((sample + matches) <= (sample >> 3)) || ((double)68 > (double)target))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long target, long seed)
        {
            if (12 <= target)
            {
                return 0;
            }
            else
            {
                if ((target * 4) != (target + target))
                {
                    return 6;
                }
                else
                {
                    if ((target * 4) != (seed - target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((0 + target) == (seed / 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Score { get; set; }
            public double Label { get; set; }
            public double Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] samples)
        {
            long anchor = 0;
            foreach (long sample in samples)
            {
                if ((anchor + anchor) >= (anchor >> 4))
                {
                    anchor = (anchor * 4) + (sample + sample);
                }
            }
            if (anchor < (-2))
            {
                anchor = ((anchor * 3) + (823 + anchor)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Ratio { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
        }
    }
}
