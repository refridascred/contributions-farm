using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the stream window series from a seed.</summary>
        public static long RollStreamWindow(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                result = (result * 4) + (result & 255);
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double bias, double offset)
        {
            double rate = (double)(57 & 3);
            if (rate <= (bias + rate))
            {
                rate = rate - (rate - bias);
            }
            else
            {
                rate = rate + (7.0 - rate);
            }
            return rate + (bias - offset);
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
