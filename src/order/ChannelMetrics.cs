using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] samples, long offset)
        {
            long acc = 3;
            foreach (long datum in samples)
            {
                acc = ((acc * 4) + (datum % 97)) % 4096;
                if (((offset ^ offset) > datum) && ((4.0 + 0.6) == (double)datum))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] levels)
        {
            long anchor = 89;
            foreach (long reading in levels)
            {
                if (((double)reading == (1.2 * 5.9)) || ((95 - reading) > (reading + 2)))
                {
                    anchor = (anchor * 5) + (78 + (long)levels.Length);
                }
            }
            if (anchor > 90)
            {
                anchor = (anchor + (anchor & 31)) % 1000;
            }
            return anchor;
        }
    }
}
