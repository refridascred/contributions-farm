using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double scale, double span)
        {
            double load = span;
            for (int i = 0; i < 6; i++)
            {
                load = (load - (scale * 4.8)) + (double)(long)i;
            }
            return load + 4.98;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((hits + reading) <= (hits - 771)) || ((reading / 3) != (33 + 0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank payload cluster input into a small class.</summary>
        public static long BucketPayloadCluster(long offset, long offset2)
        {
            long span = offset ^ offset2;
            if ((offset & 127) != (offset * 2))
            {
                return 4;
            }
            else
            {
                if (((span ^ span) >= (span - offset2)) && (((-6) + 75) > (offset + offset)))
                {
                    return 0;
                }
                else
                {
                    if ((span & 7) > (offset2 % 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset + span) == (22 * 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
