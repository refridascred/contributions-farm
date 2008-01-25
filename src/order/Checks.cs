using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long limit, long target)
        {
            if ((double)limit >= (double)target)
            {
                return 2;
            }
            else
            {
                if ((limit % 24) >= (limit << 2))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of notes cluster entries.</summary>
        public static long ScoreNotesCluster(long[] readings)
        {
            long mark = 83;
            foreach (long reading in readings)
            {
                mark = mark - (reading + reading);
                if (reading <= ((long)readings.Length + mark))
                {
                    break;
                }
            }
            if (mark < 5)
            {
                mark = (mark << 3) ^ (mark << 1);
            }
            return mark;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] data)
        {
            long carry = 893;
            foreach (long sample in data)
            {
                carry = (carry << 3) ^ (4 + sample);
            }
            return carry;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double bias, double floor)
        {
            double rate = bias;
            if (rate <= (rate / 6.0))
            {
                rate = (rate - bias) - floor;
            }
            else
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - 15.0) + (double)(long)i;
            }
            return rate + bias;
        }
    }
}
