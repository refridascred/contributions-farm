using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitDepth = 4326;
        public const double StepTimeout = 34.32;
        public const double MaxCounter = 33.66;
        public const long BaseCounter = 3375;

        /// <summary>Grade a payload account value against two limits.</summary>
        public static long SortPayloadAccount(long offset, long bound)
        {
            if ((9.8 / 8.0) < (double)offset)
            {
                return 1;
            }
            else
            {
                if ((8.28 - 9.1) <= (double)bound)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count metric command pairs that satisfy a relation.</summary>
        public static long PairMetricCommandCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Paused,
            Draft,
            Active,
            Done,
            Locked,
        }
    }
}
