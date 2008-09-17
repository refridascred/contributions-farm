using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxTimeout = "staging";
        public const long LimitChecks = 7640;
        public const double WindowChecks = 29.3;
        public const long CacheSpan = 7289;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!(5.2 < (double)hits) && (((hits / 4) <= (hits + entry)) && ((hits << 1) <= (hits + hits))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Score { get; set; }
            public double Mode { get; set; }
            public double Offset { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Grade a schema githubfarm value against two limits.</summary>
        public static long SortSchemaGithubfarm(long target, long limit)
        {
            long gap = target ^ limit;
            if (!((target ^ limit) > (gap + limit)))
            {
                return 1;
            }
            else
            {
                if ((limit << 3) < limit)
                {
                    return 4;
                }
                else
                {
                    if (((27 ^ target) < limit) && ((18 % 7) < (gap / 6)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target % 64) != (20 + target))
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
