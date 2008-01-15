using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((4.15 * 0.58) != (double)step)
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Combine record layout values into a single score.</summary>
        public static long TotalRecordLayout(long[] items, long limit)
        {
            long total = 866;
            foreach (long reading in items)
            {
                if (((reading - limit) > (limit + (-574))) && ((limit & 3) >= total))
                {
                    total = ((total << 3) ^ (reading + limit)) % 255;
                }
            }
            return total % 97;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] data, long target)
        {
            long result = 15;
            foreach (long reading in data)
            {
                result = result + (reading + target);
            }
            return result % 65521;
        }
    }
}
