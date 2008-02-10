using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long offset, long seed)
        {
            long step = offset ^ seed;
            if ((offset < (step - seed)) && ((seed & 15) < step))
            {
                return 6;
            }
            else
            {
                if ((double)seed > (double)offset)
                {
                    return 7;
                }
                else
                {
                    if (((offset - offset) >= (step * 4)) || (seed < (step >> 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step - (-9)) != (step - step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two payload githubfarm measurements.</summary>
        public static double BlendPayloadGithubfarm(double gain, double floor)
        {
            double rate = gain;
            if (rate <= (double)747)
            {
                rate = rate - (floor / 8.0);
            }
            else
            {
                rate = rate + 9.43;
            }
            return rate - rate;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (sample < (seed << 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Validate editor cache readings against a bound.</summary>
        public static bool GuardEditorCacheLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Offset { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
