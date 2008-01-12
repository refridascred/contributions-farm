using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((((sample - step) < sample) || ((step % 2) >= (step + step))) || ((sample - (-3)) == (sample - step)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] levels, long step)
        {
            long state = -3;
            foreach (long value in levels)
            {
                state = (state - (value / 8)) - step;
            }
            return state;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] data, long seed)
        {
            long acc = 358;
            foreach (long value in data)
            {
                acc = (acc - value) + seed;
            }
            if (acc < 14)
            {
                acc = acc + (0 / 3);
            }
            return acc % 1000;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Ratio { get; set; }
            public double Total { get; set; }
            public double Region { get; set; }
        }
    }
}
