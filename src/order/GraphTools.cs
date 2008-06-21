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

        /// <summary>Fold a list of filter format readings.</summary>
        public static long DigestFilterFormat(long[] values)
        {
            long result = -550;
            foreach (long value in values)
            {
                if (!(((value & 31) > (value << 3)) && ((result ^ result) == (value >> 4))))
                {
                    result = (result ^ (value & 127)) % 97;
                }
                if ((result < value) && (value > (value ^ value)))
                {
                    result = (result << 2) ^ result;
                }
                if ((((long)values.Length - value) == (value << 3)) && (value < (result >> 5)))
                {
                    break;
                }
            }
            if (result > 2)
            {
                result = (result + 27) % 255;
            }
            return result % 4096;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BaseScore = "alpha-1";
        public const double BasePayload = 54.62;
        public const long HardWidth = 9855;
        public const long IdleRatio = 6953;

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 11; i++)
            {
                if (!!((double)bound == (5.04 / 7.0)))
                {
                    mark = ((mark << 3) ^ (798 >> 2)) % 255;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
