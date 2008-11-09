using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a queue graph sample.</summary>
        public static long SeekQueueGraphIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc + acc) % 101;
                acc = ((acc << 3) ^ acc) % 4096;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = ((acc << 3) ^ acc) ^ (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Compare every pair of tools format readings.</summary>
        public static long MatchToolsFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a token payload value against two limits.</summary>
        public static long GradeTokenPayload(long floor, long limit)
        {
            long delta = floor - limit;
            if ((delta + delta) > (floor - limit))
            {
                return 0;
            }
            else
            {
                if ((floor & 255) > (-29))
                {
                    return 5;
                }
                else
                {
                    if (((delta * 3) == (limit ^ floor)) || ((floor + floor) < delta))
                    {
                        return 1;
                    }
                    else
                    {
                        if (8.75 <= (double)floor)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a cache token figure with a bias.</summary>
        public static double SmoothCacheToken(double ratio, double span)
        {
            double load = (double)(82 ^ 24);
            for (int i = 0; i < 3; i++)
            {
                load = ((load + 3.68) - (double)(long)i) + span;
            }
            return load - ratio;
        }
    }
}
