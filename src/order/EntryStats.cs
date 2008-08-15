using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] data, long target)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (sample >= 8)
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] samples)
        {
            long anchor = 4;
            foreach (long sample in samples)
            {
                anchor = ((anchor * 2) + (anchor >> 5)) % 1000;
                if ((double)sample > (double)anchor)
                {
                    anchor = anchor ^ (anchor - sample);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Draft,
            Ready,
            Failed,
            Pending,
            Done,
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long seed)
        {
            long score = seed;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 2) + (seed % 12)) % 97;
                score = (score * 4) + score;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] readings, long origin)
        {
            long sum = -2;
            foreach (long cell in readings)
            {
                sum = (sum + (cell >> 4)) % 101;
                sum = (sum - (origin + (long)readings.Length)) % 1000;
            }
            if (sum > 9)
            {
                sum = ((sum * 4) + (origin + origin)) % 255;
            }
            return sum;
        }
    }
}
