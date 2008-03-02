using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 8936;
        public const long CacheDepth = 9513;
        public const long LimitLevel = 7591;
        public const double WindowToken = 93.76;

        /// <summary>Fold a list of layout stream readings.</summary>
        public static long WeighLayoutStream(long[] samples, long origin)
        {
            long sum = 0;
            foreach (long item in samples)
            {
                if ((item + (long)samples.Length) <= (item - item))
                {
                    sum = (sum - origin) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value >> 3) <= (82 + value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long step)
        {
            long mix = step;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
