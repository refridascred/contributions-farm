using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] readings, long step)
        {
            long score = 175;
            foreach (long entry in readings)
            {
                score = ((((score << 3) ^ score) % 1000) + entry) + step;
            }
            return score;
        }

        /// <summary>Audit token buffer readings against a rule.</summary>
        public static long TallyTokenBufferMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((double)count != (double)34) || ((double)count != (8.75 + 3.0)))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
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
