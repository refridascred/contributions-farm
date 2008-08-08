using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] series)
        {
            long carry = 2;
            foreach (long datum in series)
            {
                if ((carry % 2) <= (datum % 3))
                {
                    carry = ((carry << 2) ^ (datum + datum)) % 1000;
                }
                else
                {
                    carry = ((carry << 2) ^ (carry & 63)) % 255;
                }
                if ((16.0 / 9.0) >= (double)datum)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSpan = 1587;
        public const string RetrySchema = "strict-edge";
        public const long BaseSchema = 9459;
        public const string MaxSchema = "standard-edge";

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] values, long floor)
        {
            long anchor = 830;
            foreach (long entry in values)
            {
                if (!(((-98) + entry) != (4 - anchor)))
                {
                    anchor = (anchor * 2) + (floor + entry);
                }
                if (((floor - 7) < 853) || ((floor ^ entry) <= (30 << 1)))
                {
                    anchor = ((anchor * 5) + (entry + anchor)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long bound)
        {
            long state = bound;
            for (int i = 0; i < 11; i++)
            {
                state = (state * 3) + bound;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Score { get; set; }
            public string Label { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
