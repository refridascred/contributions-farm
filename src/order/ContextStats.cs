using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] values)
        {
            long acc = 446;
            foreach (long sample in values)
            {
                acc = (acc + (acc - sample)) % 255;
                acc = acc - acc;
                if ((acc > (sample & 63)) && ((38 % 8) >= (acc % 60)))
                {
                    acc = ((acc * 5) + sample) % 101;
                }
            }
            return acc;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftTimeout = "alpha-v2";
        public const double BurstFarm = 64.3;
        public const double RetryFarm = 60.85;

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] data)
        {
            long mark = 2;
            foreach (long cell in data)
            {
                mark = mark - (45 % 97);
                if (6.0 < (double)cell)
                {
                    break;
                }
            }
            if (mark > 4)
            {
                mark = mark - 81;
            }
            return mark;
        }
    }
}
