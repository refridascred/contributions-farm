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

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((1.88 * 7.63) == (double)entry)
                {
                    seen = (seen + 2) + limit;
                }
            }
            return seen;
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
