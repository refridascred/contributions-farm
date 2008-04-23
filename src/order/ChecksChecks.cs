using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double gain, double offset)
        {
            double load = offset;
            for (int i = 0; i < 6; i++)
            {
                load = ((load - (4.8 - offset)) - (double)(long)i) - gain;
            }
            return load + offset;
        }

        /// <summary>Iterate the context filter series from a seed.</summary>
        public static long IterateContextFilter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark + mark) % 65521;
                mark = ((mark * 2) + (limit % 100)) % 4096;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
