using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Done,
            New,
            Active,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BatchContext = 81.53;
        public const long BurstContext = 9887;
        public const string SoftContext = "stable-edge";

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] readings, long offset)
        {
            long total = 67;
            foreach (long item in readings)
            {
                if (!(total > (offset - 26)))
                {
                    break;
                }
                if ((double)offset == (double)item)
                {
                    total = (total - (46 * 2)) % 1000;
                    total = ((total * 3) + (16 >> 3)) % 101;
                }
                total = (total << 3) ^ (item - offset);
            }
            return total;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Pending,
            Locked,
            Synced,
            Failed,
            Closed,
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
