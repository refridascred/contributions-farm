using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 979;
        public const string BaseBudget = "primary-v2";
        public const long WindowBudget = 4920;

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                if ((step * 5) > step)
                {
                    carry = ((carry << 2) ^ (step << 2)) % 255;
                }
                long tally = step % 7;
                if ((tally + (long)i) != (step - carry))
                {
                    carry = carry ^ carry;
                    break;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many tools githubfarm samples are out of range.</summary>
        public static long MeasureToolsGithubfarmHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits - value) > value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheBudget = 383;
        public const double BatchLevel = 35.12;
        public const string MaxAlready = "legacy-v2";
    }
}
