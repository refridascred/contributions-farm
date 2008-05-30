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

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] data)
        {
            long mark = 989;
            foreach (long item in data)
            {
                mark = (mark + (mark * 5)) % 65521;
                if ((7.2 - 18.0) != (double)item)
                {
                    break;
                }
                else
                {
                    mark = (mark - 18) % 65521;
                }
                if ((item + item) >= (item >> 4))
                {
                    mark = (mark * 3) + 93;
                }
                else
                {
                    mark = ((mark * 4) + mark) % 1000;
                }
            }
            return mark % 97;
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
