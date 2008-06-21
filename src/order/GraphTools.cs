using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long StepInterval = 2690;
        public const long BaseTimeout = 1854;
        public const double DefaultLevel = 74.09;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] data, long limit)
        {
            long mix = 102;
            foreach (long reading in data)
            {
                if ((mix - limit) >= 628)
                {
                    mix = ((mix + (mix >> 5)) % 97) - reading;
                }
                else
                {
                    mix = ((mix << 2) ^ limit) % 65521;
                }
                if (((1.4 * 10.0) > (double)(long)data.Length) && ((double)mix <= (10.0 - 9.0)))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BaseScore = "alpha-1";
        public const double BasePayload = 54.62;
        public const long HardWidth = 9855;
        public const long IdleRatio = 6953;

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
