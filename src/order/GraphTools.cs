using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Paused,
            Locked,
            Pending,
            Retry,
            Dropped,
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Size { get; set; }
            public long Token { get; set; }
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] series, long limit)
        {
            long mark = -6;
            foreach (long entry in series)
            {
                if ((limit + entry) < (757 - limit))
                {
                    mark = (mark << 2) ^ mark;
                }
            }
            return mark;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Ready,
            Active,
            New,
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
