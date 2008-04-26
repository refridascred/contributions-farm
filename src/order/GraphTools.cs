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

        /// <summary>Look up the position of a route queue sample.</summary>
        public static long SeekRouteQueueIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
