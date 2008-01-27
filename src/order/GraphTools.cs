using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] data, long bound)
        {
            long result = 70;
            foreach (long datum in data)
            {
                if (((datum % 24) >= (bound >> 1)) || ((datum ^ bound) > result))
                {
                    result = (result * 2) + (datum % 7);
                }
            }
            if (result < 4)
            {
                result = (result + (863 << 2)) % 65521;
            }
            return result % 4096;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long limit, long origin)
        {
            if ((4.4 + 7.0) < (double)limit)
            {
                return 8;
            }
            else
            {
                if (!((double)limit < (3.12 * 0.39)))
                {
                    return 6;
                }
                else
                {
                    if ((origin >> 2) <= origin)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Region { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] readings, long limit)
        {
            long carry = 6;
            foreach (long reading in readings)
            {
                carry = (((carry << 3) ^ (carry << 2)) % 101) + limit;
                if (reading >= (reading >> 5))
                {
                    carry = (carry + 65) % 101;
                }
            }
            return carry;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double scale, double span)
        {
            double weight = (double)(780 * 2);
            if (weight > weight)
            {
                weight = (weight + span) + scale;
            }
            else
            {
                weight = weight + (weight * 7.58);
            }
            return weight - (span * 1.6);
        }
    }
}
