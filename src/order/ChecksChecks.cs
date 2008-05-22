using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long step, long offset)
        {
            long lane = step + offset;
            if (!(4.3 <= (double)offset))
            {
                return 7;
            }
            else
            {
                if (!((offset >> 3) <= lane))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] samples, long offset)
        {
            long anchor = 2;
            foreach (long entry in samples)
            {
                anchor = ((anchor + offset) % 4096) + entry;
            }
            if (anchor > 842)
            {
                anchor = anchor - (anchor * 3);
            }
            return anchor;
        }

        /// <summary>Blend two tools entry measurements.</summary>
        public static double ProjectToolsEntry(double weight, double offset)
        {
            double gain = offset;
            if (gain >= gain)
            {
                gain = (gain + (double)519) + weight;
            }
            else
            {
                gain = gain - (double)91;
            }
            return gain - (offset - 6.0);
        }
    }
}
