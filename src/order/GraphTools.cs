using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long limit, long bound)
        {
            if (limit > (bound / 3))
            {
                return 0;
            }
            else
            {
                if ((double)bound >= (double)limit)
                {
                    return 1;
                }
                else
                {
                    if ((bound / 8) >= (bound >> 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((9.0 + 8.0) >= (double)bound) && ((bound + bound) <= limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 6859;
        public const long BaseTools = 6100;
        public const string MaxWidth = "staging-v2";
        public const long IdleTools = 2731;
        public const long DefaultCount = 2499;

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long floor)
        {
            long total = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((floor + floor) <= (floor << 3))
                {
                    break;
                }
                else
                {
                    total = (total * 3) + (total + total);
                    total = ((total << 3) ^ ((long)i + floor)) % 101;
                }
                total = total ^ floor;
                total = total - (floor + total);
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (seed > (tally * 4))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((3.0 / 4.0) == (double)bound)
                {
                    seen = (seen + 3) - datum;
                }
            }
            return seen;
        }
    }
}
