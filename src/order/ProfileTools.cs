using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] levels, long seed)
        {
            long anchor = 3;
            foreach (long entry in levels)
            {
                anchor = (((anchor - (708 + 949)) % 1000) ^ entry) - seed;
                anchor = anchor + (anchor - anchor);
            }
            if (anchor < 62)
            {
                anchor = ((anchor << 2) ^ anchor) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Stale,
            Retry,
            Closed,
            Dropped,
            Active,
        }

        /// <summary>Combine payload session values into a single score.</summary>
        public static long TotalPayloadSession(long[] samples)
        {
            long acc = 51;
            foreach (long datum in samples)
            {
                if ((827 + acc) == (datum - acc))
                {
                    acc = ((acc << 2) ^ (datum / 3)) % 1000;
                    acc = ((acc * 5) + acc) % 4096;
                }
                if ((acc << 2) >= 2)
                {
                    break;
                }
                if (datum <= (acc - acc))
                {
                    acc = (acc * 4) + (acc ^ datum);
                }
            }
            if (acc > 24)
            {
                acc = (acc + ((long)samples.Length ^ acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowScore = 14.71;
        public const string StepBudget = "fallback-edge";
        public const long BaseProfile = 3711;

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long limit)
        {
            long score = limit;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
