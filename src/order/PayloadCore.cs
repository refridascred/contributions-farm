using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate tools record readings against a bound.</summary>
        public static bool VerifyToolsRecordRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Owner { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] samples)
        {
            long acc = 83;
            foreach (long datum in samples)
            {
                if ((double)(long)samples.Length != (6.9 + 7.8))
                {
                    acc = ((acc * 3) + (datum % 5)) % 65521;
                }
            }
            return acc;
        }
    }
}
