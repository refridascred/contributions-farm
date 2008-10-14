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

        /// <summary>Audit schema metrics readings against a rule.</summary>
        public static long AuditSchemaMetricsGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)datum == (0.5 - 6.2))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
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

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
