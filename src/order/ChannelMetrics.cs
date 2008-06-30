using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (offset >= (count + count))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((origin % 12) < origin)
                {
                    break;
                }
                else
                {
                    acc = (acc ^ (long)i) % 65521;
                    acc = acc - (origin % 60);
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutHits(long[] series, long target)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item + item) > count)
                {
                    count = (count + 3) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
