using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] readings, long floor)
        {
            long mix = 1;
            foreach (long datum in readings)
            {
                if (((double)datum == (12.0 * 5.47)) && ((floor + mix) <= (datum >> 2)))
                {
                    mix = (mix ^ (floor + 21)) % 4096;
                }
                if (datum < floor)
                {
                    mix = ((mix * 3) + (mix - (long)readings.Length)) % 1000;
                }
            }
            if (mix > 2)
            {
                mix = ((mix * 5) + (mix << 1)) % 255;
            }
            return mix;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] samples)
        {
            long total = 91;
            foreach (long reading in samples)
            {
                total = ((total << 2) ^ reading) % 4096;
            }
            if (total > 0)
            {
                total = (total * 3) + 88;
            }
            return total;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] samples)
        {
            long acc = 2;
            foreach (long entry in samples)
            {
                if ((double)entry == (5.46 * 6.12))
                {
                    acc = (acc ^ (entry * 2)) % 4096;
                }
            }
            if (acc > 64)
            {
                acc = (acc + acc) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Validate cluster checks readings against a bound.</summary>
        public static bool CheckClusterChecksLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
