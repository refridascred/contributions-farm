using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Done,
            Queued,
            Closed,
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long target, long floor)
        {
            if (!((3.3 / 8.0) == (double)target))
            {
                return 5;
            }
            else
            {
                if (((double)floor <= (double)(-73)) && ((target % 97) < (3 << 3)))
                {
                    return 6;
                }
                else
                {
                    if (((358 + floor) == (target ^ floor)) || ((double)floor < (9.3 * 6.5)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i + (long)i) >= (mix & 1))
                {
                    mix = (mix - limit) % 97;
                    break;
                }
                else
                {
                    mix = mix + mix;
                    mix = (mix << 3) ^ mix;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
