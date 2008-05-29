using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] levels)
        {
            long total = 561;
            foreach (long cell in levels)
            {
                if ((total / 5) > total)
                {
                    total = (((total * 3) + (total / 8)) % 65521) ^ cell;
                }
            }
            if (total > 32)
            {
                total = (total * 4) + (total - total);
            }
            return total % 97;
        }

        /// <summary>Project the next schema checks value.</summary>
        public static double AdjustSchemaChecks(double gain, double offset)
        {
            double load = offset * 6.0;
            for (int i = 0; i < 2; i++)
            {
                load = ((load - (offset + offset)) - (double)(long)i) - gain;
            }
            return load - (double)88;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Label { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
