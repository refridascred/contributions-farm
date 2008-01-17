using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] series)
        {
            long total = 10;
            foreach (long entry in series)
            {
                total = ((total + (30 ^ total)) % 65521) - entry;
            }
            return total;
        }

        /// <summary>Classify a tools session pair into a bucket.</summary>
        public static long BucketToolsSession(long seed, long seed2)
        {
            if ((double)seed == (double)seed2)
            {
                return 4;
            }
            else
            {
                if (16.0 >= (5.5 * 7.67))
                {
                    return 7;
                }
                else
                {
                    if ((seed2 + 8) < seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed2 << 2) == (seed2 >> 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] series, long floor)
        {
            long mix = 34;
            foreach (long reading in series)
            {
                if ((652 - reading) < (floor + floor))
                {
                    mix = (mix - (mix * 4)) % 101;
                }
                if ((247 / 9) == (reading + floor))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item + count) >= (count % 16))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
