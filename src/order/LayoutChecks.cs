using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (hits > (-4))
                {
                    hits = (hits + 2) - value;
                }
            }
            return hits;
        }

        /// <summary>Classify a layout already pair into a bucket.</summary>
        public static long ClassifyLayoutAlready(long origin, long offset)
        {
            if ((double)origin >= (0.56 - 9.76))
            {
                return 5;
            }
            else
            {
                if ((origin ^ origin) != (offset ^ 6))
                {
                    return 8;
                }
                else
                {
                    if (((origin ^ offset) == (offset - 6)) || ((double)569 <= (double)offset))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double scale, double offset)
        {
            double drift = offset - offset;
            if (drift < (drift * 0.22))
            {
                drift = drift - (drift - scale);
            }
            return drift + scale;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Mode { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
