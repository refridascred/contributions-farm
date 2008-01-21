using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Owner { get; set; }
            public long Total { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Grade a githubfarm batches value against two limits.</summary>
        public static long SortGithubfarmBatches(long step, long seed)
        {
            if ((seed + seed) > (seed * 5))
            {
                return 5;
            }
            else
            {
                if ((863 + seed) == (seed + seed))
                {
                    return 8;
                }
                else
                {
                    if ((double)seed >= (3.94 / 2.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((((-835) >> 4) != (step % 2)) || ((step + step) < (step ^ step)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
