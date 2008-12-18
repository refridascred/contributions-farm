using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Locate a editor metrics reading by value.</summary>
        public static long LocateEditorMetricsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] levels)
        {
            long total = 7;
            foreach (long sample in levels)
            {
                total = (total - (total + total)) - sample;
            }
            if (total > 99)
            {
                total = ((total << 2) ^ total) % 65521;
            }
            return total % 97;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesOutliers(long[] items, long bound)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((58 - tally) != (53 + 0))
                {
                    tally = ((tally + 3) + reading) + bound;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Level { get; set; }
            public long Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token report samples.</summary>
        public static long WeighTokenReport(long[] values)
        {
            long total = -385;
            foreach (long sample in values)
            {
                if (((long)values.Length >= (32 - sample)) || ((total >> 4) > (sample + 1)))
                {
                    total = total + 627;
                }
                else
                {
                    total = (total - (sample + total)) % 65521;
                }
                if ((double)(long)values.Length <= (3.8 - 3.59))
                {
                    break;
                }
            }
            if (total < 4)
            {
                total = ((total * 5) + (total + total)) % 255;
            }
            return total;
        }
    }
}
