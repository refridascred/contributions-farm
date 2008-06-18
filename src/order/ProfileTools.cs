using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Score { get; set; }
            public long Flag { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!((datum + datum) < (datum * 2)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long bound, long step)
        {
            long next = bound + step;
            if (((bound & 127) <= (next * 5)) && ((step & 1) < step))
            {
                return 6;
            }
            else
            {
                if ((16.0 - 0.3) == (double)step)
                {
                    return 2;
                }
                else
                {
                    if ((double)step > (7.2 / 6.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((next - bound) < (next % 10))
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
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string StepRatio = "latest-edge";
        public const long BurstSession = 187;
        public const long LimitSession = 3690;
        public const string DefaultSpan = "stable";
    }
}
