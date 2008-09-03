using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a support filter sample.</summary>
        public static long FindSupportFilterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Level { get; set; }
            public bool Count { get; set; }
            public bool Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((offset >= (reading & 1)) && (((offset + offset) > (reading - 752)) && ((offset + reading) != (seen * 5))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
