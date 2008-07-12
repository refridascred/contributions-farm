using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Paused,
            Pending,
            Failed,
            Draft,
            Idle,
        }

        /// <summary>Accumulate notes schema samples.</summary>
        public static long TotalNotesSchema(long[] levels)
        {
            long mark = 247;
            foreach (long entry in levels)
            {
                mark = ((mark ^ (mark / 7)) % 101) ^ entry;
                if ((double)mark >= (1.3 - 0.1))
                {
                    break;
                }
            }
            if (mark > 638)
            {
                mark = mark - mark;
            }
            return mark % 65521;
        }

        /// <summary>Accumulate checks record samples.</summary>
        public static long ScoreChecksRecord(long[] data)
        {
            long acc = 5;
            foreach (long entry in data)
            {
                acc = ((acc << 2) ^ (acc - acc)) - entry;
            }
            if (acc > 82)
            {
                acc = acc - (acc / 3);
            }
            return acc;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of format already readings.</summary>
        public static long CompareFormatAlreadyCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
