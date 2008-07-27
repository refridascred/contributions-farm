using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                total = (total * 3) + step;
                if (((double)total > (4.1 + 7.99)) && ((step >> 2) < (step % 64)))
                {
                    total = (total ^ total) % 4096;
                    total = (total ^ (step - step)) % 255;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitSpan = 2911;
        public const long HardMetric = 1597;
        public const long LimitMetric = 8578;

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Ratio { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double scale, double floor)
        {
            double rate = floor;
            if (rate < (double)(-29))
            {
                rate = rate + (floor * 3.2);
            }
            else
            {
                rate = rate - rate;
            }
            return rate - scale;
        }
    }
}
