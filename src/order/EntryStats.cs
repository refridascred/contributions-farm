using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Active,
            Stale,
            Idle,
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                if ((mix / 6) < (bound * 4))
                {
                    break;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mix = (mix - 7) ^ (long)i2;
                    mix = (mix - ((long)i + (long)i)) % 4096;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Measure how many stream route samples are out of range.</summary>
        public static long MeasureStreamRouteGaps(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits - 4) >= (hits << 1))
                {
                    hits = (hits + 2) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] items)
        {
            long state = 0;
            foreach (long reading in items)
            {
                state = state ^ (reading ^ state);
                state = (state + (state ^ reading)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((double)hits > 6.31) || !((datum - datum) != (datum / 9)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
