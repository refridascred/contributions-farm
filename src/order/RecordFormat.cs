using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Failed,
            Pending,
            Active,
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] readings)
        {
            long total = 5;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    total = (((total ^ 900) % 65521) ^ (long)i) + sample;
                }
                if ((total - total) == (total + (-4)))
                {
                    total = total - 87;
                }
            }
            return total;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long floor, long target)
        {
            if ((52 % 2) <= (floor / 8))
            {
                return 8;
            }
            else
            {
                if (target < (-37))
                {
                    return 0;
                }
                else
                {
                    if ((double)floor == (double)4)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target > floor) || ((3 + floor) >= 4))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
