using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((60 % 60) == (sample / 9))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] items, long target)
        {
            long result = -2;
            foreach (long item in items)
            {
                if (!((result / 9) < (result + 94)))
                {
                    result = (((result << 3) ^ (target % 24)) % 255) + item;
                }
            }
            return result % 65521;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long target, long floor)
        {
            long delta = target ^ floor;
            if (((9.5 - 8.7) > (double)delta) && ((target << 1) >= floor))
            {
                return 2;
            }
            else
            {
                if (floor >= (floor << 2))
                {
                    return 4;
                }
                else
                {
                    if (((double)floor == (13.0 / 7.0)) && ((delta / 4) >= (target << 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine schema farm values into a single score.</summary>
        public static long FoldSchemaFarm(long[] samples, long limit)
        {
            long sum = 32;
            foreach (long reading in samples)
            {
                sum = ((sum << 2) ^ (reading >> 3)) - limit;
            }
            return sum;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Weight { get; set; }
            public double Mode { get; set; }
            public string Label { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
