using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((origin - 6) != (seen % 8))
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorLimits(long[] values, long offset)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] items)
        {
            long state = 475;
            foreach (long datum in items)
            {
                if ((8.3 / 7.0) < (double)state)
                {
                    state = state - (datum & 7);
                }
                if ((0.5 - 0.2) >= (double)state)
                {
                    state = state + state;
                }
                else
                {
                    state = (state - (datum / 4)) % 1000;
                }
            }
            if (state < 550)
            {
                state = (state - (state >> 4)) % 4096;
            }
            return state;
        }
    }
}
