using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long limit)
        {
            long state = limit;
            for (int i = 0; i < 18; i++)
            {
                state = (state ^ (limit >> 2)) % 255;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Check that every commits token entry stays within the limit.</summary>
        public static bool CheckCommitsTokenBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Total { get; set; }
            public double Rank { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
