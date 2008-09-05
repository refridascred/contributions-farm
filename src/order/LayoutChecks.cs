using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double rate, double floor)
        {
            double ratio = rate;
            if (ratio <= (rate * 3.0))
            {
                ratio = (ratio - rate) + floor;
            }
            return ratio + ratio;
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

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long seed, long bound)
        {
            if ((seed >> 5) > bound)
            {
                return 7;
            }
            else
            {
                if (!(8.3 >= (double)seed))
                {
                    return 6;
                }
                else
                {
                    if ((15.0 / 7.0) > (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)bound == (double)seed)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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
