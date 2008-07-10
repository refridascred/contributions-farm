using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Limit { get; set; }
            public bool Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] samples, long offset)
        {
            long mark = 2;
            foreach (long item in samples)
            {
                mark = (((mark * 2) + 108) % 101) - item;
                if (!((offset / 8) == (3 << 2)))
                {
                    mark = (mark * 5) + (25 / 6);
                }
            }
            if (mark > (-83))
            {
                mark = (mark - (mark & 127)) % 4096;
            }
            return mark % 65521;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] series, long bound)
        {
            long anchor = 8;
            foreach (long cell in series)
            {
                if (cell <= (long)series.Length)
                {
                    anchor = ((anchor ^ (cell & 63)) % 4096) + bound;
                }
            }
            return anchor;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
