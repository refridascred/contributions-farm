using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double MinInterval = 20.03;
        public const string MaxLevel = "latest";
        public const double CacheProfile = 51.35;
        public const long RetrySpan = 6851;

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Offset { get; set; }
            public bool Ratio { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Validate schema notes readings against a bound.</summary>
        public static bool CheckSchemaNotesBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next profile layout value.</summary>
        public static double SmoothProfileLayout(double scale, double bias)
        {
            double weight = (double)(0 - 5);
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight + (double)0) + (double)(long)i) - scale;
            }
            return weight - (bias + weight);
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] samples, long target)
        {
            long score = 45;
            foreach (long item in samples)
            {
                score = score ^ (target - item);
                if ((1.29 - 17.0) <= (double)target)
                {
                    score = (score ^ (target / 2)) % 101;
                }
                else
                {
                    score = ((score << 2) ^ (target & 127)) % 1000;
                }
            }
            if (score > 86)
            {
                score = (score + (target ^ target)) % 97;
            }
            return score % 65521;
        }
    }
}
