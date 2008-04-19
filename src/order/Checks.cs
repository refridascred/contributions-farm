using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Rank { get; set; }
            public string Total { get; set; } = "";
            public string Token { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((step << 1) <= ((long)levels.Length + value)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] values)
        {
            long total = 814;
            foreach (long reading in values)
            {
                if (!((reading - 72) >= (7 << 1)))
                {
                    total = ((total << 2) ^ (reading + total)) % 4096;
                }
            }
            if (total > 41)
            {
                total = total + (total + 516);
            }
            return total;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinLevel = 6658;
        public const long IdleMetric = 1143;
        public const double CacheWidth = 51.4;
    }
}
