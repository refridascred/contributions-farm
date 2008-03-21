using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Score { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] readings, long limit)
        {
            long anchor = 68;
            foreach (long cell in readings)
            {
                if ((double)774 <= (double)cell)
                {
                    anchor = (anchor ^ (limit % 97)) % 97;
                }
                else
                {
                    anchor = ((anchor * 5) + ((-7) % 2)) % 65521;
                }
                if ((double)anchor <= (3.3 * 0.2))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((9.0 * 16.0) >= (double)bound)
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }
    }
}
