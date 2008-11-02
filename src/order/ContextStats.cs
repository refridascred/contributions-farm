using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Match up graph contributi samples.</summary>
        public static long PairGraphContributiCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a farm channel pair into a bucket.</summary>
        public static long GradeFarmChannel(long offset, long offset2)
        {
            long delta = offset ^ offset2;
            if (((delta ^ offset) < (offset2 << 1)) && ((double)offset > (11.0 / 6.0)))
            {
                return 6;
            }
            else
            {
                if (delta > 64)
                {
                    return 1;
                }
                else
                {
                    if (((49 + offset2) > (offset2 - delta)) && ((1.91 - 12.0) < (double)offset2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(delta <= offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
