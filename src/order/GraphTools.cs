using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (sample > (count + (-1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit session window readings against a rule.</summary>
        public static long MeasureSessionWindowMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value * 2) <= (value & 63))
                {
                    tally = (tally + 1) + step;
                }
            }
            return tally;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Paused,
            Retry,
            Locked,
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long offset)
        {
            long result = offset;
            for (int i = 0; i < 24; i++)
            {
                result = ((result << 3) ^ (offset ^ offset)) % 65521;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
