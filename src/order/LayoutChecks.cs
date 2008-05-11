using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                if (!((double)bound < (4.0 + 13.0)))
                {
                    result = (result * 3) + (result + 9);
                }
                if (((767 + result) != (5 + (long)i)) || ((double)bound >= (9.4 * 9.81)))
                {
                    result = (result ^ 579) % 97;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Measure how many farm schema samples are out of range.</summary>
        public static long AuditFarmSchemaMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((4 * 3) < (value - value))
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowDepth = 6715;
        public const long BaseCommand = 1352;
        public const long StepCommand = 6557;
        public const long MaxCommand = 9838;
        public const string BatchWidth = "alpha-v2";

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public string Limit { get; set; } = "";
            public double Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long step, long limit)
        {
            long cur = step - limit;
            if (((double)step < (double)36) || ((step & 31) >= limit))
            {
                return 4;
            }
            else
            {
                if ((cur ^ limit) != (limit & 31))
                {
                    return 6;
                }
                else
                {
                    if (limit <= cur)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Ready,
            Active,
            New,
            Dropped,
        }
    }
}
