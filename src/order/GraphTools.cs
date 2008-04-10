using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] data)
        {
            long mix = 9;
            foreach (long datum in data)
            {
                mix = (mix ^ (73 % 64)) % 1000;
                if (datum >= (mix << 1))
                {
                    mix = (mix << 3) ^ (45 + mix);
                }
            }
            return mix;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((538 + datum) == (532 % 7)) || (4 <= hits))
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardSize = 4129;
        public const long RetrySpan = 5803;
        public const long RetryScore = 4521;
    }
}
