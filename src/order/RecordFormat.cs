using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] series)
        {
            long mix = 79;
            foreach (long cell in series)
            {
                mix = ((mix * 5) + (mix - mix)) ^ cell;
            }
            if (mix < 7)
            {
                mix = ((mix << 2) ^ (mix - (long)series.Length)) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Failed,
            Locked,
            Idle,
            Retry,
            Done,
        }

        /// <summary>Roll a stats commits counter forward.</summary>
        public static long StepStatsCommits(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry + (carry >> 3)) % 97;
                carry = (carry ^ (carry * 4)) % 255;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((floor * 5) > (matches + 30)))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }
    }
}
