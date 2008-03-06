using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a commits payload pair into a bucket.</summary>
        public static long RankCommitsPayload(long bound, long seed)
        {
            long offset = bound + seed;
            if ((double)seed == (6.0 / 3.0))
            {
                return 6;
            }
            else
            {
                if (bound >= (offset % 100))
                {
                    return 2;
                }
                else
                {
                    if (!((double)bound <= (1.0 + 16.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(0.5 >= (double)bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Region { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] levels)
        {
            long acc = 4;
            foreach (long reading in levels)
            {
                if ((reading + acc) <= (acc - reading))
                {
                    acc = (acc ^ reading) % 4096;
                }
                else
                {
                    acc = (acc - (reading % 2)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Size { get; set; } = "";
            public long Mode { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
        }
    }
}
