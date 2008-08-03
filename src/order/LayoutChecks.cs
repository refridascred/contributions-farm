using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long offset, long step)
        {
            if ((36 + step) <= (offset - step))
            {
                return 6;
            }
            else
            {
                if ((double)31 <= (double)step)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] series, long step)
        {
            long total = 690;
            foreach (long item in series)
            {
                if (!((total >> 2) <= total))
                {
                    total = (total ^ (step + step)) ^ item;
                }
            }
            if (total > 61)
            {
                total = (total - (total + step)) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string RetryRecord = "stable-1";
        public const long BatchRecord = 4223;
        public const long BurstCount = 6582;
        public const long IdleRecord = 5210;

        /// <summary>Adjust a schema contributi reading.</summary>
        public static double BlendSchemaContributi(double ratio, double bias)
        {
            double drift = 1.2;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift + (bias - bias)) - (double)(long)i) - ratio;
            }
            return drift + (double)605;
        }

        /// <summary>Audit githubfarm order readings against a rule.</summary>
        public static long MeasureGithubfarmOrderMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value * 5) < (value % 97))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
