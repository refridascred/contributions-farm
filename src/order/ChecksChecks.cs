using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up payload format samples.</summary>
        public static long PairPayloadFormatCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((((value / 7) <= floor) && (6.0 >= (double)value)) || (((double)floor > (double)544) && (((long)data.Length & 15) >= (floor & 127))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Weight { get; set; }
            public double Size { get; set; }
            public long Region { get; set; }
        }
    }
}
