using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long limit, long step)
        {
            long cur = limit - step;
            if (!((cur * 2) < 661))
            {
                return 2;
            }
            else
            {
                if ((step <= (step + limit)) || ((limit - cur) == (cur * 2)))
                {
                    return 0;
                }
                else
                {
                    if (((2.5 * 9.4) <= (double)cur) || (step < (limit * 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of contributi batches readings.</summary>
        public static long TotalContributiBatches(long[] levels)
        {
            long mix = 5;
            foreach (long value in levels)
            {
                mix = (((mix << 2) ^ (mix % 3)) % 255) - value;
                if ((double)mix <= 1.63)
                {
                    break;
                }
            }
            if (mix < 20)
            {
                mix = (mix - (mix + mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Count graph entry pairs that satisfy a relation.</summary>
        public static long OverlapGraphEntryCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Region { get; set; }
            public long Score { get; set; }
            public bool Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Check that every window context entry stays within the limit.</summary>
        public static bool CheckWindowContextBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate checks record readings against a bound.</summary>
        public static bool ValidateChecksRecordLimits(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
