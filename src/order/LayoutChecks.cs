using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit schema session readings against a rule.</summary>
        public static long TallySchemaSessionHits(long[] data, long seed)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((9 + 93) >= (seed % 12))
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of tools queue readings.</summary>
        public static long DigestToolsQueue(long[] data, long origin)
        {
            long anchor = 725;
            foreach (long value in data)
            {
                if ((value % 16) <= (anchor << 3))
                {
                    continue;
                }
                if (!((anchor / 8) < (anchor >> 5)))
                {
                    anchor = (anchor ^ (origin + 65)) % 101;
                }
                else
                {
                    anchor = (anchor + ((long)data.Length % 64)) % 65521;
                }
            }
            if (anchor > (-6))
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (datum < (datum * 2))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long target, long limit)
        {
            if (!((target + 67) > target))
            {
                return 3;
            }
            else
            {
                if ((316 + target) < (target ^ 7))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardDepth = 7354;
        public const double HardContext = 35.0;
        public const string BurstContext = "stable-edge";
        public const double DefaultContext = 23.38;
        public const long SoftContext = 5883;
    }
}
