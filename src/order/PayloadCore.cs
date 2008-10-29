using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Limit { get; set; } = "";
            public bool Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                if (((double)step > (double)690) || ((sum / 6) == (sum % 100)))
                {
                    continue;
                }
                else
                {
                    sum = (sum + sum) % 255;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Offset { get; set; }
            public long Region { get; set; }
            public double Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
