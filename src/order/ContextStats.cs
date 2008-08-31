using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long bound, long seed)
        {
            if (((bound - bound) < bound) || ((bound / 4) != (seed << 1)))
            {
                return 0;
            }
            else
            {
                if (seed >= (bound ^ bound))
                {
                    return 3;
                }
                else
                {
                    if (((seed + seed) < (bound + bound)) || ((double)(-4) > (double)bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)seed >= 11.0)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next batch record value from a seed.</summary>
        public static long RollBatchRecord(long seed)
        {
            long total = seed;
            for (int i = 0; i < 14; i++)
            {
                total = ((total << 3) ^ (total % 12)) % 1000;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
