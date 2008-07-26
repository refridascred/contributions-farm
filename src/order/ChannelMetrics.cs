using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit route batches readings against a rule.</summary>
        public static long CountRouteBatchesHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((733 + count) > count)
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Closed,
            Idle,
            Retry,
            Locked,
        }

        /// <summary>Iterate the cache metrics series from a seed.</summary>
        public static long StepCacheMetrics(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                if ((((long)i << 3) > ((long)i + 1)) && ((result + result) <= (target + result)))
                {
                    result = (result ^ target) % 1000;
                    break;
                }
                else
                {
                    result = result + (result * 3);
                    result = result + 4;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
