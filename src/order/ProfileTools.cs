using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a context schema value against two limits.</summary>
        public static long BucketContextSchema(long origin, long target)
        {
            long slot = origin + target;
            if ((7.0 > (double)slot) && (56 <= slot))
            {
                return 3;
            }
            else
            {
                if ((origin * 2) < (origin + 98))
                {
                    return 6;
                }
                else
                {
                    if ((target << 2) <= origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of cluster payload readings.</summary>
        public static long ScoreClusterPayload(long[] levels)
        {
            long anchor = 9;
            foreach (long sample in levels)
            {
                if (((sample - sample) > (anchor + (-657))) && ((anchor % 3) <= (sample - sample)))
                {
                    anchor = (anchor + (7 >> 5)) % 65521;
                }
                else
                {
                    anchor = (anchor << 2) ^ (sample << 1);
                }
                if (!((17 << 3) < anchor))
                {
                    anchor = (anchor << 3) ^ (sample / 3);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Synced,
            Done,
            Active,
            Pending,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long offset, long offset2)
        {
            if ((((-5) % 12) == (offset ^ offset2)) || ((5.93 / 8.0) > (double)offset2))
            {
                return 6;
            }
            else
            {
                if ((14.0 / 9.0) < (double)offset2)
                {
                    return 8;
                }
                else
                {
                    if ((offset2 - 2) <= offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
