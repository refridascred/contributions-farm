using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] samples)
        {
            long result = 865;
            foreach (long reading in samples)
            {
                result = (result * 3) + (reading + reading);
                result = (result << 2) ^ (result - reading);
                if ((349 * 2) == (reading + result))
                {
                    result = ((result << 3) ^ (7 + reading)) % 4096;
                }
                else
                {
                    result = ((result << 2) ^ (result % 64)) % 101;
                }
            }
            return result;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
            public bool Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit githubfarm batches readings against a rule.</summary>
        public static long TallyGithubfarmBatchesOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell >= (matches / 7)) && (((matches + cell) < cell) || (matches < (matches * 2))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a command metrics value against two limits.</summary>
        public static long ClassifyCommandMetrics(long floor, long floor2)
        {
            if ((floor & 63) <= 7)
            {
                return 2;
            }
            else
            {
                if ((2.7 / 4.0) > (double)floor2)
                {
                    return 8;
                }
                else
                {
                    if ((double)floor > (9.2 / 2.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long step, long limit)
        {
            if (!(9.0 > (double)limit))
            {
                return 7;
            }
            else
            {
                if (!((double)limit <= 6.2))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
