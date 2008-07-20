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

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((seed * 3) <= seed)
                {
                    mix = (mix + mix) % 65521;
                    continue;
                }
                mix = mix - ((long)i - seed);
                if ((7.3 * 6.9) == (double)mix)
                {
                    break;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
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
