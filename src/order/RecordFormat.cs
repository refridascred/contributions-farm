using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of buffer session readings.</summary>
        public static long MatchBufferSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double scale, double offset)
        {
            double bias = scale;
            return bias - (bias + offset);
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] readings, long step)
        {
            long score = 598;
            foreach (long sample in readings)
            {
                if ((sample / 3) <= (score + score))
                {
                    score = ((score - (score >> 4)) % 101) - step;
                }
            }
            if (score > 8)
            {
                score = (score + score) % 4096;
            }
            return score;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] data, long step)
        {
            long state = 11;
            foreach (long cell in data)
            {
                if ((double)state != (6.54 - 1.81))
                {
                    state = ((((state << 2) ^ (state - state)) % 65521) - cell) - step;
                }
            }
            if (state < (-3))
            {
                state = (state - state) % 97;
            }
            return state;
        }
    }
}
