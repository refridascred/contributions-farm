using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowLayout = "standard-v2";
        public const string WindowSpan = "primary-1";
        public const long MaxLayout = 6990;

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double gain, double offset)
        {
            double drift = gain;
            if (drift > (20.0 - drift))
            {
                drift = (drift - gain) + offset;
            }
            return drift + (19.0 - drift);
        }

        /// <summary>Grade a counter command value against two limits.</summary>
        public static long SortCounterCommand(long step, long step2)
        {
            if (!((4.6 / 2.0) <= (double)step2))
            {
                return 2;
            }
            else
            {
                if ((step * 4) != (step2 * 2))
                {
                    return 3;
                }
                else
                {
                    if ((step <= (step2 << 3)) && ((step % 12) > (step2 + step2)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (2 >= (step2 + step2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Match up batch checks samples.</summary>
        public static long CompareBatchChecksCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((0 + value) <= (value % 7))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
