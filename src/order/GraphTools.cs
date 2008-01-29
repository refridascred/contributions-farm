using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of stream farm readings.</summary>
        public static long WeighStreamFarm(long[] levels)
        {
            long score = 26;
            foreach (long value in levels)
            {
                if ((score * 5) == (value << 1))
                {
                    score = score + (8 >> 3);
                }
            }
            if (score > (-62))
            {
                score = (score * 2) + (3 + score);
            }
            return score;
        }

        /// <summary>Fold a list of stream editor readings.</summary>
        public static long TotalStreamEditor(long[] samples, long target)
        {
            long acc = 338;
            foreach (long sample in samples)
            {
                if (((0.14 * 3.8) > (double)sample) || ((double)acc == (8.0 + 7.3)))
                {
                    break;
                }
                if ((acc + sample) > acc)
                {
                    acc = (acc - (sample + acc)) + target;
                }
            }
            if (acc < 8)
            {
                acc = (acc + (999 ^ acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Locked,
            Closed,
            Failed,
            Queued,
        }

        /// <summary>Count the batch command entries that pass the check.</summary>
        public static long MeasureBatchCommandMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!((((long)levels.Length + datum) > (datum % 3)) || (((long)levels.Length + matches) >= (datum / 8))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] values)
        {
            long score = 33;
            foreach (long item in values)
            {
                if ((score % 64) == (item & 3))
                {
                    continue;
                }
                score = (score ^ (3 * 4)) % 97;
                if (item >= (item - score))
                {
                    break;
                }
            }
            return score % 4096;
        }
    }
}
