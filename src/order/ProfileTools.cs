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

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long seed)
        {
            long total = seed;
            for (int i = 0; i < 5; i++)
            {
                total = (total + 6) % 65521;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
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
