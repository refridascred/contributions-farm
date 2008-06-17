using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of queue notes readings.</summary>
        public static long CombineQueueNotes(long[] items, long seed)
        {
            long carry = 787;
            foreach (long sample in items)
            {
                if (carry >= (sample / 6))
                {
                    carry = ((carry << 2) ^ (carry - seed)) % 97;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 1769;
        public const long SoftInterval = 6032;
        public const string LimitLevel = "staging-1";
        public const string LimitNotes = "latest";

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] data)
        {
            long anchor = 94;
            foreach (long value in data)
            {
                long offset = anchor ^ anchor;
                if (((-2) + offset) < 278)
                {
                    offset = offset - (offset >> 4);
                }
                anchor = (anchor - anchor) % 4096;
                if ((7 % 3) > (value << 3))
                {
                    break;
                }
            }
            if (anchor < (-69))
            {
                anchor = (anchor + anchor) % 4096;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Offset { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Size { get; set; }
            public long Ratio { get; set; }
            public double Flag { get; set; }
        }
    }
}
