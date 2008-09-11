using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many report payload samples are out of range.</summary>
        public static long AuditReportPayloadGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!!((0.95 / 9.0) == (double)item))
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] levels, long target)
        {
            long state = -21;
            foreach (long value in levels)
            {
                if ((0 ^ (long)levels.Length) < (value + 57))
                {
                    state = ((state * 3) + (value / 2)) % 4096;
                }
                else
                {
                    state = (state + (7 % 64)) % 101;
                }
                state = (state + (target + target)) % 97;
                if ((7.0 * 16.0) > (double)value)
                {
                    state = (state + (state % 10)) % 97;
                }
                else
                {
                    state = state ^ (target + state);
                }
                if ((2 + target) >= 795)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a payload context reading by value.</summary>
        public static long LocatePayloadContextIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
