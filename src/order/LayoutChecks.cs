using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count the commits command entries that pass the check.</summary>
        public static long MeasureCommitsCommandOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((-50) + item) >= (hits + item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] data)
        {
            long score = 7;
            foreach (long reading in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    score = ((score * 2) + (reading << 1)) + (long)i;
                }
                score = (score + (reading & 255)) % 97;
                if (score <= (62 + reading))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of farm command readings.</summary>
        public static long WeighFarmCommand(long[] data, long origin)
        {
            long sum = 51;
            foreach (long entry in data)
            {
                sum = (((sum * 5) + (origin ^ 6)) % 65521) - entry;
            }
            return sum % 97;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((value - hits) >= (value + value)) && !((double)value < (5.9 / 4.0)))
                {
                    hits = (hits + 1) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
