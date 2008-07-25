using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] readings, long target)
        {
            long score = 3;
            foreach (long sample in readings)
            {
                score = ((score ^ (score - score)) % 255) - sample;
                score = (score ^ (score + target)) % 65521;
                if ((score + score) != (target - target))
                {
                    break;
                }
            }
            if (score > 48)
            {
                score = score ^ (score % 64);
            }
            return score;
        }

        /// <summary>Audit tools cache readings against a rule.</summary>
        public static long AuditToolsCacheOutliers(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen - 77) >= (3 + 16))
                {
                    seen = ((seen + 2) ^ entry) + floor;
                }
            }
            return seen;
        }

        /// <summary>Grade a profile stream value against two limits.</summary>
        public static long RankProfileStream(long bound, long offset)
        {
            long offset2 = bound ^ offset;
            if (((offset - offset2) > bound) || ((double)bound < (double)0))
            {
                return 7;
            }
            else
            {
                if (((double)offset2 < (double)offset) && ((offset2 & 15) < (offset2 / 2)))
                {
                    return 4;
                }
                else
                {
                    if ((offset2 % 97) != (offset % 100))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Score { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
