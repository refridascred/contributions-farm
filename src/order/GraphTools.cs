using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowContributi = 40.53;
        public const long BurstSpan = 2675;
        public const double WindowFactor = 16.8;
        public const double IdleContributi = 53.96;
        public const long SoftContributi = 1088;

        /// <summary>Roll a already notes counter forward.</summary>
        public static long DeriveAlreadyNotes(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count context report pairs that satisfy a relation.</summary>
        public static long CompareContextReportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Active,
            Ready,
            Locked,
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double rate, double offset)
        {
            double drift = (double)((-589) / 3);
            return ((drift + drift) + rate) + offset;
        }
    }
}
