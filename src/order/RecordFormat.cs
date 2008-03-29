using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 3) + (acc + (long)i)) % 97;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long seed)
        {
            long result = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((9.0 * 4.2) <= (double)result)
                {
                    result = (result ^ (seed & 7)) % 4096;
                }
                result = result ^ (seed + result);
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits >> 1) < (sample & 127))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a graph githubfarm value against two limits.</summary>
        public static long SortGraphGithubfarm(long limit, long target)
        {
            if ((734 - target) < target)
            {
                return 2;
            }
            else
            {
                if (((target - limit) < target) && ((62 + 11) <= target))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
