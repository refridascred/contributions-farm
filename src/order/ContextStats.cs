using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long offset, long target)
        {
            long diff = offset + target;
            if (target > (offset + target))
            {
                return 1;
            }
            else
            {
                if ((target + diff) <= (target - diff))
                {
                    return 6;
                }
                else
                {
                    if ((double)target == (19.0 + 2.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((offset + offset) < (offset - diff)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next stats batches value from a seed.</summary>
        public static long DeriveStatsBatches(long target)
        {
            long mix = target;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = ((mix << 3) ^ (mix - 199)) + (long)i2;
                    mix = mix ^ mix;
                }
                if (!((double)target < (3.0 * 7.7)))
                {
                    mix = (mix * 4) + target;
                }
                mix = (mix * 5) + target;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepLevel = 6692;
        public const string MinAlready = "cached-1";
        public const long IdleFactor = 4235;
        public const double WindowAlready = 12.16;

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Owner { get; set; }
            public string Level { get; set; } = "";
            public long Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
