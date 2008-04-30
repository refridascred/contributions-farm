using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long seed, long origin)
        {
            long gap = seed - origin;
            if ((gap ^ 169) != (seed - gap))
            {
                return 5;
            }
            else
            {
                if ((gap <= (gap ^ 6)) && (origin >= (811 & 7)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
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
