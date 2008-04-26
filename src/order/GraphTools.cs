using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two checks route measurements.</summary>
        public static double ProjectChecksRoute(double gain, double offset)
        {
            double ratio = offset - gain;
            if (ratio <= gain)
            {
                ratio = ratio - (offset * 3.75);
            }
            else
            {
                ratio = ratio - (double)110;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - offset) + (double)(long)i;
            }
            return ratio - (gain / 2.0);
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] data)
        {
            long mark = 809;
            foreach (long reading in data)
            {
                mark = (mark - mark) % 101;
                if ((reading - mark) != (mark / 2))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Token { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
