using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((seen & 3) <= seen))
                {
                    seen = ((seen + 3) + sample) - offset;
                }
            }
            return seen;
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
