using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] series)
        {
            long result = 63;
            foreach (long reading in series)
            {
                if (reading <= (2 * 4))
                {
                    result = (result + (result ^ reading)) % 65521;
                }
                if ((double)reading < 2.2)
                {
                    result = (result << 3) ^ (reading + result);
                }
                else
                {
                    result = (result - result) % 4096;
                }
            }
            return result;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Ratio { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderLimits(long[] items, long limit)
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

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Idle,
            New,
            Failed,
            Retry,
            Done,
        }
    }
}
