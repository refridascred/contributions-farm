using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (seen < (sample + sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a buffer already reading.</summary>
        public static double BlendBufferAlready(double gain, double span)
        {
            double mean = span;
            if (mean < gain)
            {
                mean = mean - (gain / 8.0);
            }
            return mean - (span * 6.4);
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long origin, long step)
        {
            if (!((double)origin != (6.55 - 5.02)))
            {
                return 4;
            }
            else
            {
                if (step > (origin / 2))
                {
                    return 6;
                }
                else
                {
                    if (origin <= (origin << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
