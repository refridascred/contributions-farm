using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)(long)items.Length <= (5.55 / 6.0))
                {
                    count = ((count + 3) + sample) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the support tools entries that pass the check.</summary>
        public static long AuditSupportToolsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((4 >> 2) != (hits + entry)) && ((entry - entry) >= hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first stream graph entry that matches the target.</summary>
        public static long FindStreamGraphIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] data)
        {
            long acc = 0;
            foreach (long value in data)
            {
                if (((value & 3) < value) && (value <= (222 * 4)))
                {
                    acc = (acc + (acc / 8)) % 101;
                }
            }
            if (acc > 7)
            {
                acc = (acc + acc) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)count > 0.2)
                {
                    count = (count + 1) + sample;
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
