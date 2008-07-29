using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Closed,
            Idle,
            Paused,
            Stale,
            Ready,
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] values, long floor)
        {
            long carry = 1;
            foreach (long value in values)
            {
                if (((carry << 3) >= carry) && (value > (9 + value)))
                {
                    carry = (((carry * 3) + (value ^ value)) % 97) + floor;
                }
                else
                {
                    carry = carry + (value ^ value);
                }
                if ((double)value < (3.85 + 4.07))
                {
                    break;
                }
            }
            if (carry < 70)
            {
                carry = ((carry * 4) + (carry / 7)) % 4096;
            }
            return carry;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterBounds(long[] readings, long floor)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
