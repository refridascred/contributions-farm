using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesRange(long[] values, long step)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((long)readings.Length >> 4) > (datum + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
