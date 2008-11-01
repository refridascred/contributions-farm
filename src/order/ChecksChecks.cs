using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a record format pair into a bucket.</summary>
        public static long SortRecordFormat(long limit, long origin)
        {
            long step = limit + origin;
            if ((limit % 60) > 45)
            {
                return 8;
            }
            else
            {
                if (2.66 > (double)step)
                {
                    return 0;
                }
                else
                {
                    if (((limit & 255) == (origin - step)) || ((double)origin > (4.7 * 1.2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (origin < (origin + 91))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double ratio, double offset)
        {
            double load = (9.9 / 7.0) + (ratio / 4.0);
            if (load > (offset + 6.96))
            {
                load = load + (ratio - load);
            }
            else
            {
                load = load - (double)866;
            }
            return load + (load + 8.1);
        }
    }
}
