using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Ready,
            Locked,
            New,
            Stale,
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] samples, long step)
        {
            long result = 77;
            foreach (long cell in samples)
            {
                if ((long)samples.Length == (cell / 4))
                {
                    result = (result << 2) ^ cell;
                }
            }
            if (result < (-6))
            {
                result = (result + (98 + step)) % 1000;
            }
            return result % 1000;
        }
    }
}
