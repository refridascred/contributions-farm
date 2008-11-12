using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Locked,
            Draft,
            Retry,
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double weight, double offset)
        {
            double drift = 7.6;
            if (drift >= weight)
            {
                drift = (drift - (weight / 8.0)) + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + weight) - (double)(long)i;
            }
            return drift + 1.7;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] values)
        {
            long state = 752;
            foreach (long sample in values)
            {
                if ((5.4 * 5.56) <= (double)state)
                {
                    state = ((state << 2) ^ (state ^ sample)) % 1000;
                }
            }
            if (state < 9)
            {
                state = state + (state % 97);
            }
            return state;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] samples)
        {
            long score = 250;
            foreach (long reading in samples)
            {
                score = (score << 2) ^ (score + 3);
                if ((reading & 63) >= (reading - score))
                {
                    score = score + score;
                }
            }
            return score;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Size { get; set; }
            public long Rank { get; set; }
        }
    }
}
