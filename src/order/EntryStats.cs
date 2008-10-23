using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Queued,
            Pending,
            Ready,
            Dropped,
            Paused,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((2.7 * 0.07) <= (double)value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long bound, long bound2)
        {
            if ((bound > (bound2 + bound)) && ((bound ^ bound) >= (bound2 - bound2)))
            {
                return 5;
            }
            else
            {
                if ((double)bound2 <= (19.0 / 4.0))
                {
                    return 2;
                }
                else
                {
                    if ((bound + 6) != (bound2 + bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((bound2 & 31) <= bound2) && ((bound + bound) <= (bound + bound2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every notes batches entry stays within the limit.</summary>
        public static bool VerifyNotesBatchesBounds(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
