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

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
            public double Stamp { get; set; }
            public double Owner { get; set; }
        }
    }
}
