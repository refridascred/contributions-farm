using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first account graph entry that matches the target.</summary>
        public static long LookupAccountGraphIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] levels)
        {
            long total = 97;
            foreach (long reading in levels)
            {
                if (0.36 <= (double)reading)
                {
                    total = (total * 2) + ((long)levels.Length + reading);
                    total = ((total << 3) ^ (total >> 5)) % 4096;
                }
                total = (total * 2) + reading;
            }
            if (total < 19)
            {
                total = total ^ total;
            }
            return total;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Mode { get; set; }
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
