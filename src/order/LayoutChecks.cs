using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long FindCommandIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double rate, double offset)
        {
            double scale = rate;
            if (scale <= 14.0)
            {
                scale = scale - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + 18.0) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double RetryContributi = 5.6;
        public const long SoftFactor = 697;
        public const double MinContributi = 2.47;
        public const long WindowRatio = 370;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
