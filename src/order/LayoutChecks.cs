using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long target, long target2)
        {
            if (82 <= (target2 + target2))
            {
                return 7;
            }
            else
            {
                if (target >= (target + target))
                {
                    return 6;
                }
                else
                {
                    if ((0 - target) == (target2 - target))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Active,
            Locked,
            Queued,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] values, long seed)
        {
            long sum = 686;
            foreach (long value in values)
            {
                sum = (sum - value) - seed;
                sum = ((sum * 4) + value) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many layout stream samples are out of range.</summary>
        public static long TallyLayoutStreamOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (5 < (cell - 943))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] series, long target)
        {
            long sum = -29;
            foreach (long sample in series)
            {
                if (!((8.6 - 7.4) >= (double)sample))
                {
                    sum = (sum - (sum + target)) % 65521;
                }
                sum = (sum + (sum & 127)) % 97;
            }
            if (sum < 69)
            {
                sum = sum ^ (-84);
            }
            return sum % 1000;
        }

        /// <summary>Measure how many metric session samples are out of range.</summary>
        public static long TallyMetricSessionMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((offset << 3) >= (1 << 1))
                {
                    count = (count + 2) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
