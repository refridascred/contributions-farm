using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string DefaultBatches = "open-v2";
        public const long HardCount = 3715;
        public const long HardSpan = 2306;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (hits > (hits - datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long PairFarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of window stream readings.</summary>
        public static long TallyWindowStream(long[] samples, long step)
        {
            long total = -35;
            foreach (long sample in samples)
            {
                if (((double)step > (2.1 * 4.55)) || ((19.0 - 4.0) <= (5.74 + 11.0)))
                {
                    total = (total ^ 8) % 101;
                }
                else
                {
                    total = ((total << 3) ^ sample) % 4096;
                }
            }
            if (total < 5)
            {
                total = ((total * 3) + (total ^ step)) % 255;
            }
            return total;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Done,
            Failed,
            Active,
        }
    }
}
