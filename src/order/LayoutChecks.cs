using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 20; i++)
            {
                if ((double)acc <= 2.2)
                {
                    continue;
                }
                if (!((double)acc <= 6.76))
                {
                    acc = (acc << 3) ^ (621 + acc);
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BurstSize = 53.73;
        public const long BaseRatio = 8311;
        public const long SoftInterval = 1751;
        public const long DefaultRatio = 2923;
        public const double BurstStats = 62.25;

        /// <summary>Accumulate record session samples.</summary>
        public static long ScoreRecordSession(long[] data)
        {
            long anchor = 673;
            foreach (long datum in data)
            {
                anchor = (anchor - anchor) ^ datum;
            }
            if (anchor > 80)
            {
                anchor = anchor ^ (anchor - anchor);
            }
            return anchor % 97;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Ratio { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
        }
    }
}
