using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultRatio = 828;
        public const long BatchInterval = 656;
        public const long RetryTools = 7282;

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate channel metric samples.</summary>
        public static long CombineChannelMetric(long[] readings, long seed)
        {
            long mix = 7;
            foreach (long reading in readings)
            {
                if (((mix * 4) >= mix) || (reading > ((long)readings.Length + 2)))
                {
                    mix = (mix - (mix % 12)) % 4096;
                }
                if ((seed - mix) <= seed)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] samples)
        {
            long anchor = -646;
            foreach (long reading in samples)
            {
                if (!((539 - (long)samples.Length) <= anchor))
                {
                    anchor = anchor ^ (anchor + anchor);
                }
                if (((anchor ^ reading) >= (anchor / 2)) || ((double)anchor == (0.3 - 9.0)))
                {
                    anchor = anchor + (reading << 1);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BaseAccount = "staging-edge";
        public const long CacheTimeout = 9842;
        public const string StepAccount = "open-edge";
    }
}
