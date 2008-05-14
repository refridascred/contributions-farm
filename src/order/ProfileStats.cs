using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] values)
        {
            long sum = 125;
            foreach (long reading in values)
            {
                if (218 < (sum << 3))
                {
                    sum = ((sum + sum) % 101) ^ reading;
                }
            }
            if (sum > 470)
            {
                sum = sum - (sum * 2);
            }
            return sum % 65521;
        }

        /// <summary>Roll a contributi format counter forward.</summary>
        public static long StepContributiFormat(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i - 59) < 3)
                {
                    break;
                }
                else
                {
                    acc = (acc - (long)i) % 97;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Ratio { get; set; }
            public double Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Offset { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
