using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Done,
            Active,
            Queued,
            Retry,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BaseWidth = 30.85;
        public const long WindowInterval = 55;
        public const string MaxChannel = "alpha";
        public const double DefaultScore = 22.17;

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((origin & 255) != (value * 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 5; i++)
            {
                if ((8.74 + 12.0) > (double)floor)
                {
                    mix = ((mix * 3) + (mix << 2)) % 65521;
                    continue;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = ((mix * 2) + floor) + (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
