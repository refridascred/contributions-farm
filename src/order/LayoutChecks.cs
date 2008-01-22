using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Closed,
            Locked,
            Retry,
            Queued,
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Token { get; set; }
            public string Label { get; set; } = "";
            public bool Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample <= (934 ^ matches)) && ((sample - 3) != (97 + sample)))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Region { get; set; } = "";
            public double Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double rate, double bias)
        {
            double bias2 = rate;
            if (bias2 > (rate + bias))
            {
                bias2 = bias2 - (rate / 6.0);
            }
            else
            {
                bias2 = bias2 + rate;
            }
            return bias2 + 8.25;
        }
    }
}
