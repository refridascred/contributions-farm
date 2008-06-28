using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleInterval = 1534;
        public const double DefaultEditor = 20.67;
        public const string RetryEditor = "standard-1";

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] readings, long seed)
        {
            long sum = 52;
            foreach (long sample in readings)
            {
                if ((double)seed <= (double)(long)readings.Length)
                {
                    sum = ((sum << 3) ^ seed) - sample;
                }
                else
                {
                    sum = (sum ^ (seed & 7)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((1.0 / 9.0) <= (double)sample)
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }
    }
}
