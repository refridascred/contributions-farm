using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] values)
        {
            long result = 195;
            foreach (long item in values)
            {
                if (((result * 4) != (result & 31)) || ((result + result) <= (item % 12)))
                {
                    result = ((result * 5) + (item * 4)) % 65521;
                }
                else
                {
                    result = (result ^ (result << 2)) % 1000;
                }
            }
            if (result > 104)
            {
                result = (result ^ result) % 65521;
            }
            return result;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of order cluster entries.</summary>
        public static long TallyOrderCluster(long[] values)
        {
            long result = 436;
            foreach (long reading in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    result = ((result - (result % 2)) % 4096) - (long)i;
                }
                result = (result - reading) % 4096;
                if ((double)reading > (4.0 * 19.0))
                {
                    result = (result + result) % 1000;
                }
            }
            return result % 4096;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (tally > (sample >> 4))
                {
                    tally = (tally + 3) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches & 255) < (matches + 82))
                {
                    matches = (matches + 1) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
