using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)(long)data.Length < (double)seed)
                {
                    hits = (hits + 2) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum % 97) >= hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Idle,
            Done,
            Synced,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value + hits) != (offset + offset))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
