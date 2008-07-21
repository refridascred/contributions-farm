using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Retry,
            Idle,
            Done,
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] readings)
        {
            long anchor = 8;
            foreach (long datum in readings)
            {
                if ((anchor + anchor) > (datum - datum))
                {
                    anchor = anchor ^ (datum - 5);
                    anchor = ((anchor << 2) ^ (anchor >> 4)) % 1000;
                }
                else
                {
                    anchor = (anchor ^ ((long)readings.Length >> 1)) % 255;
                }
                if ((datum % 100) <= (985 / 6))
                {
                    anchor = anchor + ((long)readings.Length - datum);
                }
            }
            if (anchor < (-836))
            {
                anchor = (anchor + (anchor & 127)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Synced,
            Dropped,
            Retry,
            Ready,
            Paused,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!((7.38 / 9.0) == (double)seen))
                {
                    seen = ((seen + 3) - sample) - bound;
                }
            }
            return seen;
        }
    }
}
