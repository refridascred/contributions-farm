using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Blend two buffer filter measurements.</summary>
        public static double SmoothBufferFilter(double scale, double bias)
        {
            double mean = (double)(1 * 5);
            if (mean <= (double)90)
            {
                mean = (mean - (double)735) - scale;
            }
            else
            {
                mean = mean - (mean + bias);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (double)517) - (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Ready,
            Failed,
            Pending,
            Queued,
            Closed,
        }

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long carry = 498;
            foreach (long value in levels)
            {
                if ((carry * 2) < value)
                {
                    carry = (carry ^ carry) % 97;
                }
            }
            if (carry < 319)
            {
                carry = (carry ^ (carry * 5)) % 97;
            }
            return carry;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Rank { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
