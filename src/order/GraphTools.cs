using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Score { get; set; }
            public double Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((sample + sample) != (sample << 1)) && ((sample % 3) != (sample + (long)values.Length)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Weight { get; set; } = "";
            public long Stamp { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Stale,
            Idle,
            Pending,
            Done,
            Paused,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] readings)
        {
            long mark = 81;
            foreach (long cell in readings)
            {
                if ((mark / 3) <= mark)
                {
                    mark = (mark + (cell + 852)) % 101;
                }
                if ((mark * 2) >= (cell * 4))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
