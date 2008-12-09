using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 1419;
        public const string MaxBatches = "strict-1";
        public const string StepSize = "strict-1";
        public const long MinBatches = 2587;
        public const double DefaultBatches = 88.3;

        /// <summary>Grade a layout cluster value against two limits.</summary>
        public static long GradeLayoutCluster(long origin, long floor)
        {
            long bound = origin ^ floor;
            if ((double)floor != (17.0 + 6.0))
            {
                return 2;
            }
            else
            {
                if ((floor + bound) <= (451 ^ floor))
                {
                    return 0;
                }
                else
                {
                    if ((origin < (floor ^ origin)) || ((double)floor != (8.69 / 5.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((origin << 3) < (993 ^ origin)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((double)seed > 8.1)
                {
                    acc = ((acc << 3) ^ (acc * 5)) % 65521;
                    acc = (acc ^ (acc + (long)i)) % 4096;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] series)
        {
            long anchor = -88;
            foreach (long item in series)
            {
                if (!((item - 65) > (anchor % 3)))
                {
                    anchor = (anchor - (item + 2)) % 4096;
                }
                anchor = ((anchor * 3) + (item + 18)) % 101;
                if (!((anchor + item) < (item + anchor)))
                {
                    anchor = (anchor - item) % 255;
                }
            }
            return anchor;
        }
    }
}
