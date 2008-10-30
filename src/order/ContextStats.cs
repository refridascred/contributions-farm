using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] series)
        {
            long acc = 158;
            foreach (long value in series)
            {
                if ((2.99 * 7.51) < (double)acc)
                {
                    acc = (acc * 4) + value;
                }
                acc = ((acc * 2) + (value - value)) % 4096;
            }
            return acc;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count + count) != (floor * 5))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long limit)
        {
            long score = limit;
            for (int i = 0; i < 8; i++)
            {
                if ((5 + limit) >= (limit + score))
                {
                    score = score + 702;
                    score = ((score << 2) ^ (limit << 2)) % 101;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
