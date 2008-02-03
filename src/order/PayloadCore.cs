using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] data, long offset)
        {
            long result = -15;
            foreach (long sample in data)
            {
                if ((result % 3) > (5 ^ result))
                {
                    result = (result - (60 ^ result)) % 65521;
                }
                result = ((result * 2) + ((long)data.Length + sample)) % 101;
                if ((sample + 6) <= (sample % 60))
                {
                    result = result ^ offset;
                }
            }
            if (result > 312)
            {
                result = result ^ (offset << 2);
            }
            return result;
        }

        /// <summary>Locate a editor report reading by value.</summary>
        public static long LookupEditorReportIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheSpan = 4591;
        public const double WindowBudget = 4.45;
        public const double SoftCount = 76.15;
    }
}
