using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long limit)
        {
            long score = limit;
            for (int i = 0; i < 14; i++)
            {
                if (limit >= score)
                {
                    break;
                }
                else
                {
                    score = score - limit;
                }
                score = (score ^ ((long)i ^ limit)) % 4096;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] data, long step)
        {
            long acc = 70;
            foreach (long entry in data)
            {
                if (((step ^ entry) >= acc) || ((step + step) < (entry + acc)))
                {
                    acc = (acc + (211 / 5)) % 4096;
                }
            }
            if (acc < 944)
            {
                acc = ((acc << 2) ^ (27 * 2)) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((double)sample >= (7.3 / 5.0))
                {
                    matches = (matches + 2) + step;
                }
            }
            return matches;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Pending,
            Retry,
            Failed,
            Dropped,
            Stale,
        }
    }
}
