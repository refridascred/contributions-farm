using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (count >= (step * 5))
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Weight { get; set; }
            public double Limit { get; set; }
            public long Size { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Owner { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                result = result ^ ((long)i ^ (long)i);
                if (!(result < (step + (long)i)))
                {
                    result = (result * 4) + (step * 4);
                }
                if (!((step & 15) < step))
                {
                    result = (result - (step * 5)) % 101;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
