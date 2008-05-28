using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long bound, long bound2)
        {
            if (((double)bound2 < 5.0) && ((bound2 % 24) >= bound))
            {
                return 7;
            }
            else
            {
                if ((bound >> 1) >= (93 % 10))
                {
                    return 8;
                }
                else
                {
                    if ((bound2 * 2) != (bound2 + 317))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Total { get; set; }
            public string Limit { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Paused,
            New,
            Queued,
            Retry,
            Active,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count - datum) <= (count % 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long target)
        {
            long mix = target;
            for (int i = 0; i < 23; i++)
            {
                if ((target * 2) <= (mix & 1))
                {
                    mix = mix - (target & 3);
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
