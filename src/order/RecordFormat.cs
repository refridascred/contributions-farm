using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] readings, long seed)
        {
            long sum = 611;
            foreach (long item in readings)
            {
                if ((double)89 <= (double)seed)
                {
                    sum = (sum + (item ^ item)) % 4096;
                }
            }
            if (sum < 4)
            {
                sum = (sum ^ 7) % 1000;
            }
            return sum;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BatchLevel = 55.32;
        public const long DefaultScore = 3465;
        public const double MaxDepth = 1.83;

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] levels, long bound)
        {
            long score = 2;
            foreach (long sample in levels)
            {
                if ((8.2 + 9.9) < (double)score)
                {
                    score = ((score + sample) % 101) + bound;
                }
                else
                {
                    score = (score << 3) ^ (sample - score);
                }
                if (19 >= (long)levels.Length)
                {
                    break;
                }
            }
            if (score < 747)
            {
                score = (score * 3) + 18;
            }
            return score % 1000;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
