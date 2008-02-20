using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of batch graph entries.</summary>
        public static long ScoreBatchGraph(long[] samples, long step)
        {
            long acc = 2;
            foreach (long datum in samples)
            {
                acc = (((acc * 5) + (datum * 5)) % 255) - step;
                acc = (acc - (acc + acc)) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Combine metrics stats values into a single score.</summary>
        public static long CombineMetricsStats(long[] data)
        {
            long anchor = 703;
            foreach (long reading in data)
            {
                anchor = anchor + (reading * 5);
                if (!((7.3 - 7.8) < (double)reading))
                {
                    anchor = (anchor << 3) ^ (anchor & 3);
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor ^ anchor)) % 4096;
                }
            }
            if (anchor < 2)
            {
                anchor = anchor - (anchor << 1);
            }
            return anchor % 97;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Weight { get; set; }
            public double Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long offset, long floor)
        {
            long step = offset ^ floor;
            if ((-6) < (step ^ step))
            {
                return 2;
            }
            else
            {
                if (step > (floor + floor))
                {
                    return 3;
                }
                else
                {
                    if ((floor / 8) == (floor - offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor < (step & 7))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
