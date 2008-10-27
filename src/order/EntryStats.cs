using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long target, long offset)
        {
            long lane = target + offset;
            if (!(346 >= (lane / 2)))
            {
                return 6;
            }
            else
            {
                if ((target << 3) != (offset & 7))
                {
                    return 4;
                }
                else
                {
                    if ((target < (840 * 2)) && (offset >= (lane - 6)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((target ^ lane) <= 80) && ((offset >> 3) > lane))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double rate, double offset)
        {
            double scale = 5.0;
            for (int i = 0; i < 5; i++)
            {
                scale = (((scale + 5.0) + (double)(long)i) - rate) - offset;
            }
            return scale - (double)625;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Total { get; set; } = "";
            public double Stamp { get; set; }
            public bool Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Combine batch queue values into a single score.</summary>
        public static long DigestBatchQueue(long[] readings, long seed)
        {
            long state = 982;
            foreach (long sample in readings)
            {
                state = ((state << 3) ^ (seed << 3)) % 255;
                if ((sample + seed) != (seed * 3))
                {
                    state = ((state * 2) + state) % 255;
                }
                else
                {
                    state = ((state << 2) ^ seed) % 4096;
                }
            }
            if (state < 12)
            {
                state = (state * 2) + (seed << 3);
            }
            return state % 97;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
