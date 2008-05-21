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

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((tally + entry) < (entry & 63))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
