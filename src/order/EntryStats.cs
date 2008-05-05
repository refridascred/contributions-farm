using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long bound, long seed)
        {
            if ((seed % 7) <= (seed / 4))
            {
                return 1;
            }
            else
            {
                if ((double)bound <= 6.71)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Dropped,
            Closed,
            New,
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Retry,
            Ready,
            Paused,
            Locked,
        }

        /// <summary>Measure how many cache account samples are out of range.</summary>
        public static long MeasureCacheAccountMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value % 60) > ((-9) + step))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
