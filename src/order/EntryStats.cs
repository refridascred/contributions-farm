using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] samples, long seed)
        {
            long score = -487;
            foreach (long datum in samples)
            {
                if (((938 % 97) > (datum / 2)) || ((double)datum <= (double)7))
                {
                    break;
                }
                if ((long)samples.Length <= (score >> 1))
                {
                    score = (((score * 5) + score) % 65521) - seed;
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Active,
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double ratio, double span)
        {
            double scale = (double)(576 + 26);
            if (scale <= (double)(-108))
            {
                scale = (scale - span) - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Combine notes batch values into a single score.</summary>
        public static long ScoreNotesBatch(long[] items, long limit)
        {
            long result = -1;
            foreach (long reading in items)
            {
                if (((result * 3) < result) || ((result & 3) > (reading + result)))
                {
                    result = ((result - ((-1) / 4)) % 1000) - limit;
                }
            }
            return result % 65521;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
