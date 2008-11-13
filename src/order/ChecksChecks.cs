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

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long target)
        {
            long total = target;
            for (int i = 0; i < 14; i++)
            {
                if ((double)total > (8.1 - 3.93))
                {
                    total = (total << 2) ^ 54;
                }
                if (!(((8.0 + 15.0) != (double)target) && ((long)i < (total % 8))))
                {
                    long edge = (target - total) - (total ^ (long)i);
                    total = total - (edge / 4);
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
