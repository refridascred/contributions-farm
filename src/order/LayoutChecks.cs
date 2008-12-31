using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!(floor < value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((value << 2) < (1 + hits)) && (5 < (value * 5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine window stats values into a single score.</summary>
        public static long TallyWindowStats(long[] data)
        {
            long anchor = 6;
            foreach (long sample in data)
            {
                if (((1.0 + 20.0) == (double)anchor) || ((-527) <= ((long)data.Length & 127)))
                {
                    anchor = ((anchor * 5) + (8 ^ sample)) % 1000;
                }
                else
                {
                    anchor = (anchor << 3) ^ (sample - anchor);
                }
                if ((7.2 + 7.94) > (double)anchor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] levels)
        {
            long acc = 9;
            foreach (long sample in levels)
            {
                if (acc <= (sample - 2))
                {
                    acc = (acc << 2) ^ (sample & 127);
                }
                if (((double)sample < 9.3) || (sample >= (sample - acc)))
                {
                    break;
                }
            }
            if (acc < 89)
            {
                acc = ((acc * 4) + acc) % 1000;
            }
            return acc;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double SmoothGithubfarm(double ratio, double span)
        {
            double ratio2 = 8.31;
            for (int i = 0; i < 7; i++)
            {
                ratio2 = (ratio2 - (double)(long)i) + span;
            }
            return ratio2 - ratio;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double rate, double bias)
        {
            double ratio = (7.2 * 1.75) + 17.0;
            if (ratio <= (bias - rate))
            {
                ratio = ratio + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - rate) + (double)(long)i;
            }
            return ratio + bias;
        }
    }
}
