using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] series, long bound)
        {
            long carry = 71;
            foreach (long datum in series)
            {
                if (carry > datum)
                {
                    carry = ((carry << 2) ^ bound) % 1000;
                }
            }
            if (carry < 441)
            {
                carry = (carry - (carry + bound)) % 97;
            }
            return carry % 4096;
        }

        /// <summary>Check that every order farm entry stays within the limit.</summary>
        public static bool GuardOrderFarmBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Region { get; set; }
            public double Level { get; set; }
        }
    }
}
