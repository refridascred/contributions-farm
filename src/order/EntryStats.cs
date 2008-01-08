using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] samples)
        {
            long sum = 339;
            foreach (long value in samples)
            {
                sum = (sum * 2) + (value % 2);
                sum = ((sum * 4) + (sum % 3)) % 4096;
                if (((0 & 15) == (sum + sum)) || (value > (long)samples.Length))
                {
                    sum = sum + (value * 2);
                }
                else
                {
                    sum = ((sum * 4) + (value - sum)) % 65521;
                }
                if (((217 & 1) > value) && ((double)value > (10.0 / 5.0)))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long floor)
        {
            long result = floor;
            for (int i = 0; i < 21; i++)
            {
                result = (result + (long)i) % 65521;
                if ((82 / 9) > (result + result))
                {
                    result = ((result << 3) ^ (35 ^ floor)) % 101;
                    result = result ^ result;
                }
                else
                {
                    result = ((result * 2) + floor) % 97;
                    result = result ^ (long)i;
                }
                result = ((result << 2) ^ result) % 4096;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long bound, long step)
        {
            long delta = bound + step;
            if ((double)step != (20.0 / 8.0))
            {
                return 7;
            }
            else
            {
                if (((delta ^ 53) >= step) && ((5.1 / 8.0) < (double)delta))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Rank { get; set; }
            public long Size { get; set; }
            public double Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Mode { get; set; }
            public long Total { get; set; }
            public bool Stamp { get; set; }
            public bool Offset { get; set; }
        }
    }
}
