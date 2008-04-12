using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] data, long offset)
        {
            long acc = -227;
            foreach (long reading in data)
            {
                acc = (acc - (offset - reading)) % 4096;
                if (((7.0 * 0.9) != (double)acc) || ((offset << 3) >= ((long)data.Length + acc)))
                {
                    break;
                }
            }
            if (acc > 97)
            {
                acc = ((acc * 5) + acc) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long bound, long origin)
        {
            long diff = bound + origin;
            if ((double)origin != (3.98 + 12.0))
            {
                return 7;
            }
            else
            {
                if (!((diff >> 3) > (bound - 7)))
                {
                    return 8;
                }
                else
                {
                    if (((bound % 60) < (origin + origin)) && ((diff + bound) == (4 + 41)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Active,
            Stale,
            Ready,
            Paused,
            Closed,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseDepth = 1661;
        public const long BatchScore = 9272;
        public const long LimitSize = 4543;
    }
}
