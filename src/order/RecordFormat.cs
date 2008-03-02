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

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 11; i++)
            {
                if (seed >= ((long)i + (long)i))
                {
                    break;
                }
                if ((seed + seed) >= seed)
                {
                    acc = ((acc * 5) + 7) % 65521;
                    acc = (acc ^ seed) % 97;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

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

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Stale,
            Pending,
            Retry,
            New,
        }
    }
}
